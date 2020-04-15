using System;
using System.Linq;
using DashboardDevOps.Data;
using DashboardDevOps.Interface;
using DashboardDevOps.Models;
using Microsoft.Extensions.Logging;
using System.Security.Claims;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Authentication;
using System.Collections.Generic;

namespace DashboardDevOps.Business
{
    public class BLogin : ILogin
    {
        private readonly ILogger<BLogin> _logger;
        private DataContext _context; 
        private readonly IHttpContextAccessor _httpContextAccessor;

        public BLogin(ILogger<BLogin> logger, DataContext context, IHttpContextAccessor httpContextAccessor)//UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager, 
        {
            this._logger = logger;
            this._context = context;
            this._httpContextAccessor = httpContextAccessor;
        }

        public MiddleOneReturn CheckAccess(string user, string pass)
        {
            MiddleOneReturn md = new MiddleOneReturn();
            md.codigo = 0;

            try
            {
                if(user == "admin" && pass == "admin"){
                    //Roles Authorization
                    var claims = new[] { new Claim(ClaimTypes.Name, user), new Claim(ClaimTypes.Role, "Admin") };

                    var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

                    var principal = new ClaimsPrincipal();
                    principal.AddIdentity(claimsIdentity);

                    this._httpContextAccessor.HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal);
                    //Fim Roles Authorization

                    md.codigo = 0;
                    md.mensagem = new object[] { "Admin" };
                }
                else
                {
                    TB_USUARIO dbUsuario = _context.Usuario.Where(v => v.DSC_LOGIN.Equals(user) && v.DSC_SENHA.Equals(pass)).FirstOrDefault();

                    if(dbUsuario != null)
                    {
                        List<string> funcoes = (from p in _context.Perfil
                                                join pf in _context.PerfilFuncao on p.ID_PERFIL equals pf.ID_PERFIL
                                                join f in _context.Funcao on pf.ID_FUNCAO equals f.ID_FUNCAO
                                                where p.ID_PERFIL.Equals(dbUsuario.ID_PERFIL)
                                                select f.DSC_COD_FUNCAO).Distinct().ToList();

                        if(funcoes.Count > 0){
                            //Roles Authorization
                            List<Claim> claims = new List<Claim>();
                            claims.Add(new Claim(ClaimTypes.Name, dbUsuario.DSC_LOGIN));

                            foreach(var f in funcoes){
                                claims.Add(new Claim(ClaimTypes.Role, f));
                            }

                            var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

                            var principal = new ClaimsPrincipal();
                            principal.AddIdentity(claimsIdentity);

                            this._httpContextAccessor.HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal);
                            //Fim Roles Authorization

                            md.codigo = 0;
                            md.mensagem = new object[] { dbUsuario.DSC_LOGIN };
                        }
                        else
                        {
                            md.mensagem = new object[] { "Usuário sem funções de acesso as paginas!" };
                            _logger.LogError(md.mensagem[0].ToString());
                        }
                    }
                    else
                    {
                        md.mensagem = new object[] { "Usuário não encontrado!" };
                        _logger.LogError(md.mensagem[0].ToString());
                    }
                }


            }
            catch(Exception ex){
                md.mensagem = new object[] { "Error: " + ex.ToString() };
                _logger.LogError(md.mensagem[0].ToString());
            }

            return md;
        }    
    }
}
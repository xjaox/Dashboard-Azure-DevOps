public class MiddleOneReturn
    {
        public MiddleOneReturn() { }

        public MiddleOneReturn(int Codigo, params object[] Mensagem)
        {
            codigo = Codigo;
            mensagem = Mensagem;
        }

        public int codigo { get; set; }
        public object[] mensagem { get; set; }
    }
namespace DashboardDevOps.Business.Shared
{
    public class BAzureAPI
    {
        //Developed untill here!
        //Bellow example

        // public class Program
        // {
        //     //============= Config [Edit these with your settings] =====================
        //     internal const string vstsCollectionUrl = "https://dev.azure.com/softwaredevops/"; //change to the URL of your VSTS account; NOTE: This must use HTTPS
        //     internal const string clientId = "C425C52F-76DA-438A-869D-CC0CD5D4D484";        //update this with your Application ID from step 2.6 (do not change this if you have an MSA backed account)
        //     //==========================================================================

        //     internal const string VSTSResourceId = "499b84ac-1321-427f-aa17-267ca6975798"; //Static value to target VSTS. Do not change
            

        //     public static void Main(string[] args)
        //     {
        //         GetBuilds();

        //         AuthenticationContext ctx = GetAuthenticationContext(null);
        //         AuthenticationResult result = null;
        //         try
        //         {
        //             DeviceCodeResult codeResult = ctx.AcquireDeviceCodeAsync(VSTSResourceId, clientId).Result;
        //             Console.WriteLine("You need to sign in.");
        //             Console.WriteLine("Message: " + codeResult.Message + "\n");
        //             result = ctx.AcquireTokenByDeviceCodeAsync(codeResult).Result;

        //             var bearerAuthHeader = new AuthenticationHeaderValue("Bearer", result.AccessToken);
        //             ListProjects(bearerAuthHeader);
        //         }
        //         catch (Exception ex)
        //         {
        //             Console.ForegroundColor = ConsoleColor.Red;
        //             Console.WriteLine("Something went wrong.");
        //             Console.WriteLine("Message: " + ex.Message + "\n");
        //         }
        //     }

        //     public static async void GetBuilds()
        //     {
        //         try
        //         {
        //             var personalaccesstoken = "53ixjvj4dskm7qf3ssnji5sddvv56ezluvnk3slz5h2bsgdilpkq";

        //             using (HttpClient client = new HttpClient())
        //             {
        //                 client.DefaultRequestHeaders.Accept.Add(
        //                     new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

        //                 client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic",
        //                     Convert.ToBase64String(
        //                         System.Text.ASCIIEncoding.ASCII.GetBytes(
        //                             string.Format("{0}:{1}", "", personalaccesstoken))));

        //                 using (HttpResponseMessage response = client.GetAsync(
        //                             "https://dev.azure.com/softwaredevops/MOBWATCH/_apis/wit/workitems?ids=50&api-version=5.1").Result)
        //                 {
        //                     response.EnsureSuccessStatusCode();
        //                     string responseBody = await response.Content.ReadAsStringAsync();
        //                     Console.WriteLine(responseBody);
        //                 }
        //             }
        //         }
        //         catch (Exception ex)
        //         {
        //             Console.WriteLine(ex.ToString());
        //         }
        //     }

        //     private static AuthenticationContext GetAuthenticationContext(string tenant)
        //     {
        //         AuthenticationContext ctx = null;
        //         if (tenant != null)
        //             ctx = new AuthenticationContext("https://login.microsoftonline.com/" + tenant);
        //         else
        //         {
        //             ctx = new AuthenticationContext("https://login.windows.net/common");
        //             if (ctx.TokenCache.Count > 0)
        //             {
        //                 string homeTenant = ctx.TokenCache.ReadItems().First().TenantId;
        //                 ctx = new AuthenticationContext("https://login.microsoftonline.com/" + homeTenant);
        //             }
        //         }

        //         return ctx;
        //     }

        //     private static void ListProjects(AuthenticationHeaderValue authHeader)
        //     {
        //         // use the httpclient
        //         using (var client = new HttpClient())
        //         {
        //             client.BaseAddress = new Uri(vstsCollectionUrl);
        //             client.DefaultRequestHeaders.Accept.Clear();
        //             client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
        //             client.DefaultRequestHeaders.Add("User-Agent", "VstsRestApiSamples");
        //             client.DefaultRequestHeaders.Add("X-TFS-FedAuthRedirect", "Suppress");
        //             client.DefaultRequestHeaders.Authorization = authHeader;

        //             // connect to the REST endpoint            
        //             HttpResponseMessage response = client.GetAsync("_apis/projects?stateFilter=All&api-version=2.2").Result;

        //             // check to see if we have a succesfull respond
        //             if (response.IsSuccessStatusCode)
        //             {
        //                 Console.WriteLine("\tSuccesful REST call");
        //                 Console.WriteLine(response.Content.ReadAsStringAsync().Result);
        //             }
        //             else if (response.StatusCode == System.Net.HttpStatusCode.Unauthorized)
        //             {
        //                 throw new UnauthorizedAccessException();
        //             }
        //             else
        //             {
        //                 Console.WriteLine("{0}:{1}", response.StatusCode, response.ReasonPhrase);
        //             }
        //         }
        //     }
        // }
    }
}
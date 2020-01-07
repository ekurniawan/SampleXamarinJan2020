using AutoWrapper.Server;
using Newtonsoft.Json;
using SampleMobileXam.Helpers;
using SampleMobileXam.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace SampleMobileXam.Services
{
    public class BranchServices
    {
        private HttpClient _client;
        public BranchServices()
        {
            _client = new HttpClient();
        }

        public async Task<List<Branch>> GetAll()
        {
            List<Branch> lstBranch = null;
            var uri = new Uri(UrlHelper.GetUrl() + "mdbranch");
            try
            {
                var response = await _client.GetAsync(uri);
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    var results =
                        Unwrapper.Unwrap<List<Branch>>(content);
                    lstBranch = results;
                }
                else
                {
                    throw new Exception("Error: Gagal ambil data Branch");
                }
                return lstBranch;
            }
            catch (Exception ex)
            {
                throw new Exception($"{ex.Message}");
            }
        }
    }
}

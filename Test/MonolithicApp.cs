using RestSharp;
using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Test
{
    class MonolithicApp
    {
        static void Main(string[] args)
        {
            GetProductData();       

            Console.WriteLine("Hello World!");
        }


        static void GetProductData()
        {
            var client = new RestClient("http://docxtool.azurewebsites.net/api/");


            var request = new RestRequest("product");

            var response = client.Execute(request);



            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                List<Product> returnData = JsonConvert.DeserializeObject<List<Product>>(response.Content);

                foreach (var item in returnData)
                {
                    Console.WriteLine("Item ID == {0}  , Item Name =={1} Item Description =={2}  ", item.ProdId, item.ProdName, item.Description);
                }

            }
        }

    }


    public class Product
    {
        public string ProdId { get; set; }
        public string ProdName { get; set; }

        public string Description { get; set; }
    }




}

using Azure.Storage.Blobs;
using LiteraAPPServices.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace LiteraAPPServices.Services
{
    public class ProductService
    {
        private string storageConnection = "DefaultEndpointsProtocol=https;AccountName=literadatastorage;AccountKey=1X6/5+H0svMD3rJtOMbequAFEGOsYYKqlkFih9vuJwzhFZhWR0v/LMspceoE56a7goT8EDULuzll+AStfBFFmw==;EndpointSuffix=core.windows.net";

        public IEnumerable<Product> GetProducts()
        {
            BlobServiceClient _blobServiceCLient = new BlobServiceClient(storageConnection);
            BlobContainerClient _containerClient = _blobServiceCLient.GetBlobContainerClient("data");
            BlobClient _client = _containerClient.GetBlobClient("ProductDetails.json");

            var response = _client.DownloadContent();
            var l_reader = new StreamReader(response.Value.Content.ToStream());
            return JsonSerializer.Deserialize<Product[]>(l_reader.ReadToEnd());
        }

        public Product GetProduct(string productID)
        {
            IEnumerable<Product> products = this.GetProducts();
            Product _product = products.FirstOrDefault(p => p.ProdId == productID);

            return _product;
        }

    }
}

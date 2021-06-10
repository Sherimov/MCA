using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;

namespace Mca.InterviewTask.App
{
    class Program
    {
        static void Main(string[] args)
        {
            var receiptApi = "https://interview-task-api.mca.dev/qr-scanner-codes/alpha-qr-gFpwhsQ8fkY1";

            var receiptJson = string.Empty;
            using (var webClient = new WebClient())
            {
                receiptJson = webClient.DownloadString(receiptApi);
            }

            var productList = JsonConvert.DeserializeObject<List<Product>>(receiptJson);

            var domesticList = new ProductList(productList.Where(receiptItem => receiptItem.Domestic),ProductListType.Domestic);
            var importedList = new ProductList(productList.Where(receiptItem => !receiptItem.Domestic), ProductListType.Imported);

            var receipt = new Receipt(new List<ProductList> { domesticList, importedList});

            Console.WriteLine(receipt.ToString());
           
            Console.ReadLine();
        }
    }
}

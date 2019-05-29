using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Blob;



namespace App4.Activities
{
    [Activity(Label = "DownloadfrmBlob")]
    public class DownloadfrmBlob : Activity
    {
        public static void DownloadFileAsync(String BlobPath,String DevicePath)
        {
            //FileStream stream = new FileStream(Path, FileMode.Open);
            var storageAccount = new CloudStorageAccount(new Microsoft.WindowsAzure.Storage.Auth.StorageCredentials("clarify", "1uKpJnx1bKx+GWDsv+ZPbilsFxOO6lqd21XzyQixb2uGeHNPTHb1w1TaxKUlcMVDkAKezgj0Bb9Hb4+SHYb6Mg=="), true);

            var blobClient = storageAccount.CreateCloudBlobClient();

            var container = blobClient.GetContainerReference("answers");

            var blob = container.GetBlobReference(BlobPath);
            blob.DownloadToFileAsync(DevicePath,FileMode.CreateNew);
        }
}
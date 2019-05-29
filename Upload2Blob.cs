using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Blob;
using System.Threading.Tasks;
using System.IO;

namespace App4.Activities
{
    public class Upload2Blob
    {
        public static void UploadFileAsync(String Path)
        {
            //FileStream stream = new FileStream(Path, FileMode.Open);
            var storageAccount = new CloudStorageAccount(new Microsoft.WindowsAzure.Storage.Auth.StorageCredentials("clarify", "1uKpJnx1bKx+GWDsv+ZPbilsFxOO6lqd21XzyQixb2uGeHNPTHb1w1TaxKUlcMVDkAKezgj0Bb9Hb4+SHYb6Mg=="),true);

            var blobClient = storageAccount.CreateCloudBlobClient();

            var container = blobClient.GetContainerReference("answers");
            container.CreateIfNotExistsAsync();
            container.SetPermissionsAsync(new BlobContainerPermissions()
            {
                PublicAccess = BlobContainerPublicAccessType.Blob
            });
            var blob = container.GetBlockBlobReference(Path);
            blob.UploadFromFileAsync(Path);
            
        }
    }
}
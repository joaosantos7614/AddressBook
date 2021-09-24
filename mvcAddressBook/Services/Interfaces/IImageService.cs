using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace mvcAddressBook.Services.Interfaces
{
    interface IImageService // had to change to public to solve accessibility issue
    {
        public Task<byte[]> ConvertFileToByteArrayAsync(IFormFile file);
        public string ConvertByteArrayToFile(byte[] fileData, string extension);
    }
}

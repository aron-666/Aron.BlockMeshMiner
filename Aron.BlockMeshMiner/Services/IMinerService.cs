using OpenQA.Selenium.Chrome;

namespace Aron.BlockMeshMiner.Services
{
    public interface IMinerService
    {
        public ChromeDriver driver { get; set; }

        void Start();
        void Stop();
    }
}
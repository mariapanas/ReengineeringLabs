using EchoTspServer;

namespace NetSdrClientApp
{
    public class ClassToTestReffrences
    {
        public void CreateServer()
        {
            var server = new EchoServer(5000);
        }
    }
}
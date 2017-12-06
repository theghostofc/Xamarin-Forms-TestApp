using System;
namespace TestApp
{
    public interface IPlatformServices
    {
        string GetPlatformName();

        string GetUserName();

        void SetUserName(string name);

        string GetDocumentsPath();
    }
}

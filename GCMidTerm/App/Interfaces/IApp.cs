//adding "using MidtermProject." so that we can access the new interfaces we created in the folder hierarchy

namespace MidtermProject.Interfaces
{
    interface IApp
    {
        bool IsRunning { get; set; }

        void Run();
    }
}

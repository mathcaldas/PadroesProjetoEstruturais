using Facade.src;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            HomeTheaterFacade homeTheater = new HomeTheaterFacade(
                new DvdPlayer(),
                new Projector(),
                new Lights(),
                new SoundSystem()
                
            );

            homeTheater.PlayMovie("Inception");
            homeTheater.EndMovie();
        }
    }
}
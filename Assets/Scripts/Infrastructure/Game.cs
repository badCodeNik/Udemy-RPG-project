using Services.InputService;
using UnityEngine.Device;

namespace Infrastructure
{
    public class Game
    {
        public static IInputService InputService;

        public Game()
        {
            RegisterInputService();
        }

        private static void RegisterInputService()
        {
            if (Application.isEditor)
                InputService = new StandAloneInputService();
            else
                InputService = new MobileInputService();
        }
    }
}
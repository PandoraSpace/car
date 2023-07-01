using Code.Providers;
using VContainer.Unity;

namespace Code.Services
{
    public class InputService : ITickable
    {
        private readonly UIProvider _ui;

        public float Acceleration { get; private set; }
        public float Steering { get; private set; }
        public float Break { get; private set; }

        public InputService(UIProvider ui)
        {
            _ui = ui;
        }

        public void Tick()
        {
            AccelHandle();
            SteeringHandle();
            BreakHandle();
        }

        private void BreakHandle()
        {
            Break = _ui.Break.IsDown ? 1f : 0f;
        }

        private void AccelHandle()
        {
            if (_ui.Up.IsDown) Acceleration = 1f;
            if (_ui.Down.IsDown) Acceleration = -1f;

            if (!_ui.Up.IsDown && !_ui.Down.IsDown)
                Acceleration = 0f;
        }

        private void SteeringHandle()
        {
            if (_ui.Left.IsDown) Steering = -1f;
            if (_ui.Right.IsDown) Steering = 1f;

            if (!_ui.Left.IsDown && !_ui.Right.IsDown)
                Steering = 0f;
        }
    }
}
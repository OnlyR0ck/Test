using System;

namespace TestTask.Commands
{
    /*
     * TODO: Про применение команды я написал в классе ComputerClass, здесь же хочу обосновать
     * использование абстрактного класса вместо того чтобы реализовывать интерфейс у
     * конкретных команд напрямую.
     * Всё просто, по хорошему в Execute неплохо было бы иметь общую логику для всех комманд,
     * позволяющую следить за их жизненным циклом. Например, завести в интерфейсе свойство IsRunning,
     * которое показывало бы нам, активна ли данная команда сейчас. И уже в методах Execute, Cancel
     * ставить все команды в IsRunning.
     * OnComplete - переменная-делегат, которая по факту является встроенным в C# паттерном Наблюдатель.
     * Нужна для того, чтобы нам не пришлось по несколько раз опрашивать команду, а завершилась ли оно.
     * Просто подписываемся на OnComplete и передаём свой каллбек.
     */
    public abstract class Command : ICommand
    {
        public Action onComplete;
    
        public void Execute()
        {
            HandleStart();
            onComplete?.Invoke();
        }

        public void Cancel() => HandleCancel();


        protected abstract void HandleStart();
        protected abstract void HandleCancel();
    }
}
namespace Battleships.Lib.Controllers.Interfaces
{
    internal interface IMediaController
    {
        void ChangeVolume();

        void PauseMusic();

        void PlayMusic();

        void SetSpecialEffects(bool state);
    }
}
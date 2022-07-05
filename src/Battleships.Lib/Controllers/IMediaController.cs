namespace Battleships.Lib.Controllers
{
    internal interface IMediaController
    {
        void ChangeVolume();

        void PauseMusic();

        void PlayMusic();

        void SetSpecialEffects(bool state);
    }
}
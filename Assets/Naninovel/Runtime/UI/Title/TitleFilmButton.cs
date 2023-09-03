// Copyright 2022 ReWaffle LLC. All rights reserved.

namespace Naninovel.UI
{
    public class TitleFilmButton: ScriptableButton
    {
        private IUIManager uiManager;

        protected override void Awake()
        {
            base.Awake();

            uiManager = Engine.GetService<IUIManager>();
        }

        protected override void OnButtonClick() => uiManager.GetUI<IFilmScreenI>().Show();
    }
}

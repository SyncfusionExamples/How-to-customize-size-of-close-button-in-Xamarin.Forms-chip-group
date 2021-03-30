using System;
using System.Collections.Generic;
using System.Text;

namespace ChipCustomization
{
    public class Language
    {
        public Xamarin.Forms.Command CloseButtonTapped { get; set; }

        public string Name { get; set; }
        public Language()
        {
            CloseButtonTapped = new Xamarin.Forms.Command(TapCloseButton);
        }

        private void TapCloseButton(object e)
        {

            ViewModel viewModel = e as ViewModel;
            viewModel.Languages.Remove(this);
        }

    }
}

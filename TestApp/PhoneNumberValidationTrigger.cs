using System;
using Xamarin.Forms;

namespace TestApp
{
    public class PhoneNumberValidationTrigger : TriggerAction<Entry>
    {
        public PhoneNumberValidationTrigger()
        {
        }

        protected override void Invoke(Entry sender)
        {
            sender.TextColor = sender.Text.Length == 10 ? Color.Black : Color.Red;
        }
    }
}

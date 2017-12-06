using System;
using Xamarin.Forms;

namespace TestApp
{
    public class PhoneValidationBehavior : Behavior<Entry>
    {
        public PhoneValidationBehavior()
        {
        }

        protected override void OnAttachedTo(Entry bindable)
        {
            base.OnAttachedTo(bindable);
            bindable.TextChanged += Bindable_TextChanged;
        }

        protected override void OnDetachingFrom(Entry bindable)
        {
            base.OnDetachingFrom(bindable);
            bindable.TextChanged -= Bindable_TextChanged;
        }

        void Bindable_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}

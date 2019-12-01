using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamarinFormApp.Controls
{
    public class CustomRadioButton : View
    {
        public static readonly BindableProperty CheckedProperty =
            BindableProperty.Create(
                nameof(Checked),
                typeof(bool),
                typeof(CustomRadioButton),
                false
                );


        /// The default text property.
        /*public static readonly BindableProperty TextProperty =
            BindableProperty.Create<CustomRadioButton, string>(
                p => p.Text, string.Empty);*/
        public static readonly BindableProperty TextPoperty =
             BindableProperty.Create(
                 nameof(Text),
                 typeof(string),
                 typeof(CustomRadioButton),
                 string.Empty
                 );



        // Identifies the TextColor bindable property.
        /*public static readonly BindableProperty TextColorProperty =
            BindableProperty.Create<CustomRadioButton, Color>(
                p => p.TextColor, Color.Black);*/
        public static readonly BindableProperty TextColorProperty =
           BindableProperty.Create(
               nameof(TextColor),
               typeof(Color),
               typeof(CustomRadioButton),
               Color.Black
               );

        /// The checked changed event.
        //public EventHandler<EventArgs<bool>> CheckedChanged;


       

        /// Gets or sets a value indicating whether the control is checked.
        public bool Checked
        {
            get
            {
                return (bool)this.GetValue(CheckedProperty);
               // return this.GetValue<bool>(CheckedProperty);
            }

            set
            {
                this.SetValue(CheckedProperty, value);
                //var eventHandler = this.CheckedChanged;
                //if (eventHandler != null)
                //{
                //    eventHandler.Invoke(this, value);
                //}
            }
        }
        public string Text
        {
            get
            {
                return (string)GetValue(TextPoperty);
                //return this.GetValue<string>(TextProperty);
            }

            set
            {
                this.SetValue(TextPoperty, value);
            }
        }
        public Color TextColor
        {
            get
            {
                return (Color)this.GetValue(TextColorProperty);
                //return this.GetValue<Color>(TextColorProperty);
            }

            set
            {
                this.SetValue(TextColorProperty, value);
            }
        }
        public int Id { get; set; }
    }
}

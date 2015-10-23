using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TableListSample.Models;
using Xamarin.Forms;

namespace TableListSample.Controls
{
    public class TableRow : ContentView
    {
        protected override void OnBindingContextChanged()
        {
            base.OnBindingContextChanged();

            if (this.BindingContext != null)
            {
                TestModel model = this.BindingContext as TestModel;

                AbsoluteLayout layout = new AbsoluteLayout();
                this.Content = layout;

                var label1 = new Label() { Text = model.Name1, TextColor = Color.Black };
                var label2 = new Label() { Text = model.Value1, TextColor = Color.Black };
                var label3 = new Label() { Text = model.Name2, TextColor = Color.Black };
                var label4 = new Label() { Text = model.Value2, TextColor = Color.Black };

                layout.Children.Add(label1);
                layout.Children.Add(label2);
                layout.Children.Add(label3);
                layout.Children.Add(label4);

                // size:何等分するか。nは何個目の要素か
                var SetLayoutFlags = new Action<View, double, double>((label, size, n) =>
                {
                    AbsoluteLayout.SetLayoutFlags(label, AbsoluteLayoutFlags.WidthProportional | AbsoluteLayoutFlags.XProportional);
                    AbsoluteLayout.SetLayoutBounds(label, new Rectangle((n - 1) / (size - 1), 0, (1d / size), AbsoluteLayout.AutoSize));

                    // 枠線を設定
                    var border = new BoxView() { WidthRequest = 0.5, Color = Color.Gray };
                    layout.Children.Add(border);
                    AbsoluteLayout.SetLayoutFlags(border, AbsoluteLayoutFlags.XProportional | AbsoluteLayoutFlags.HeightProportional);
                    AbsoluteLayout.SetLayoutBounds(border, new Rectangle((1d / size) * n, 0, AbsoluteLayout.AutoSize, 1));
                });

                SetLayoutFlags(label1, 4, 1);
                SetLayoutFlags(label2, 4, 2);
                SetLayoutFlags(label3, 4, 3);
                SetLayoutFlags(label4, 4, 4);
            }
        }
    }
}

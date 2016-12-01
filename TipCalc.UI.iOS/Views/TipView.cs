using MvvmCross.Binding.BindingContext;
using MvvmCross.iOS.Views;
using TipCalc.Core.ViewModels;

namespace TipCalc.UI.iOS.Views
{
    //Extendemos essa classe para ligar a viewmodel
    public partial class TipView : MvxViewController<TipViewModel>
    {
        public TipView() : base("TipView", null)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            //Esses bindings fazem mesma coisa do axml no android
            //Um TipLabel(nome do treco) foi ligado ao Tip da VM
            this.CreateBinding(TipLabel).To((TipViewModel vm) => vm.Tip).Apply();
            this.CreateBinding(SubTotalTextField).To((TipViewModel vm) => vm.Generosity).Apply();
            this.CreateBinding(GenerositySlider).To((TipViewModel vm) => vm.Generosity).Apply();
        }
    }
}
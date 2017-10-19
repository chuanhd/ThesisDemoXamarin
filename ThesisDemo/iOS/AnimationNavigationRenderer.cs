using CoreAnimation;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(NavigationPage), typeof(AnimationNavigationRenderer))]

public class AnimationNavigationRenderer : NavigationRenderer
{
    public override void PushViewController(UIViewController viewController, bool animated)
    {
        if (animated)
        {
            UIView.Animate(0.75, () =>
            {
                UIView.SetAnimationCurve(UIViewAnimationCurve.EaseInOut);
                base.PushViewController(viewController, false);
                UIView.SetAnimationTransition(UIViewAnimationTransition.FlipFromLeft, this.View, false);
            });
        }
        else
        {
            base.PushViewController(viewController, false);
        }
    }

    //public override UIViewController PopViewController(bool animated)
    //{
    //    if (animated)
    //    {
    //        // Alternative way with different set of trannsition
    //        UIView.Animate(0.75, () =>
    //        {
    //            UIView.SetAnimationCurve(UIViewAnimationCurve.EaseInOut);
    //            UIView.SetAnimationTransition(UIViewAnimationTransition.FlipFromRight, this.View, false);
    //        });


    //        //var transition = CATransition.CreateAnimation();
    //        //transition.Duration = 0.75;
    //        //transition.Type = CAAnimation.TransitionFromTop;

    //        //View.Layer.AddAnimation(transition, null);

    //        return base.PopViewController(false);
    //    }
    //    else
    //    {
    //        return base.PopViewController(false);
    //    }
    //}
}


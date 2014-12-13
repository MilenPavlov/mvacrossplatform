using System;
using System.Collections.Generic;
using System.Drawing;
using HeritageProperties.iOS;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace HeritagePropertiesiOS
{
    public partial class HeritagePropertiesiOSViewController : UIViewController
    {
        public HeritagePropertiesiOSViewController(IntPtr handle)
            : base(handle)
        {
        }

        public override void DidReceiveMemoryWarning()
        {
            // Releases the view if it doesn't have a superview.
            base.DidReceiveMemoryWarning();

            // Release any cached data, images, etc that aren't in use.
        }

        #region View lifecycle


        public List<HeritageProperty> Properties { get; set; } 
        public async override void ViewDidLoad()
        {
            Console.WriteLine("ViewDidLoad()");
            base.ViewDidLoad();

            // Perform any additional setup after loading the view, typically from a nib.
            this.Properties = await HeritagePropertyService.Default.Load();
            tableViewProperties.Source = new HeritagePropertiesTableViewSource(Properties);
            tableViewProperties.ReloadData();
        }

        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);
        }

        public override void ViewDidAppear(bool animated)
        {
            base.ViewDidAppear(animated);
        }

        public override void ViewWillDisappear(bool animated)
        {
            base.ViewWillDisappear(animated);
        }

        public override void ViewDidDisappear(bool animated)
        {
            base.ViewDidDisappear(animated);
        }

        #endregion
    }
}
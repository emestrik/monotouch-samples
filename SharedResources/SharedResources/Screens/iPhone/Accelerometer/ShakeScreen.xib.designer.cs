// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 2.0.50727.1433
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace Example_SharedResources.Screens.iPhone.Accelerometer {
	
	
	// Base type probably should be MonoTouch.UIKit.UIViewController or subclass
	[MonoTouch.Foundation.Register("ShakeScreen")]
	public partial class ShakeScreen {
		
		private MonoTouch.UIKit.UIView __mt_view;
		
		private MonoTouch.UIKit.UILabel __mt_lblShakeStatus;
		
		#pragma warning disable 0169
		[MonoTouch.Foundation.Connect("view")]
		private MonoTouch.UIKit.UIView view {
			get {
				this.__mt_view = ((MonoTouch.UIKit.UIView)(this.GetNativeField("view")));
				return this.__mt_view;
			}
			set {
				this.__mt_view = value;
				this.SetNativeField("view", value);
			}
		}
		
		[MonoTouch.Foundation.Connect("lblShakeStatus")]
		private MonoTouch.UIKit.UILabel lblShakeStatus {
			get {
				this.__mt_lblShakeStatus = ((MonoTouch.UIKit.UILabel)(this.GetNativeField("lblShakeStatus")));
				return this.__mt_lblShakeStatus;
			}
			set {
				this.__mt_lblShakeStatus = value;
				this.SetNativeField("lblShakeStatus", value);
			}
		}
	}
}

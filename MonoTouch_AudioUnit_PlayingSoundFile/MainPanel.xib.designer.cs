// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 2.0.50727.1433
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace ToneGen {
	
	
	// Base type probably should be MonoTouch.UIKit.UIViewController or subclass
	[MonoTouch.Foundation.Register("MainPanel")]
	public partial class MainPanel {
		
		private MonoTouch.UIKit.UIView __mt_view;
		
		private MonoTouch.UIKit.UIButton __mt__playButton;
		
		private MonoTouch.UIKit.UIButton __mt__stopButton;
		
		private MonoTouch.UIKit.UITextField __mt__baseFreqTextField;
		
		private MonoTouch.UIKit.UITextField __mt__bufferLengthTextField;
		
		private MonoTouch.UIKit.UITextField __mt__messageTextField;
		
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
		
		[MonoTouch.Foundation.Connect("_playButton")]
		private MonoTouch.UIKit.UIButton _playButton {
			get {
				this.__mt__playButton = ((MonoTouch.UIKit.UIButton)(this.GetNativeField("_playButton")));
				return this.__mt__playButton;
			}
			set {
				this.__mt__playButton = value;
				this.SetNativeField("_playButton", value);
			}
		}
		
		[MonoTouch.Foundation.Connect("_stopButton")]
		private MonoTouch.UIKit.UIButton _stopButton {
			get {
				this.__mt__stopButton = ((MonoTouch.UIKit.UIButton)(this.GetNativeField("_stopButton")));
				return this.__mt__stopButton;
			}
			set {
				this.__mt__stopButton = value;
				this.SetNativeField("_stopButton", value);
			}
		}
		
		[MonoTouch.Foundation.Connect("_baseFreqTextField")]
		private MonoTouch.UIKit.UITextField _baseFreqTextField {
			get {
				this.__mt__baseFreqTextField = ((MonoTouch.UIKit.UITextField)(this.GetNativeField("_baseFreqTextField")));
				return this.__mt__baseFreqTextField;
			}
			set {
				this.__mt__baseFreqTextField = value;
				this.SetNativeField("_baseFreqTextField", value);
			}
		}
		
		[MonoTouch.Foundation.Connect("_bufferLengthTextField")]
		private MonoTouch.UIKit.UITextField _bufferLengthTextField {
			get {
				this.__mt__bufferLengthTextField = ((MonoTouch.UIKit.UITextField)(this.GetNativeField("_bufferLengthTextField")));
				return this.__mt__bufferLengthTextField;
			}
			set {
				this.__mt__bufferLengthTextField = value;
				this.SetNativeField("_bufferLengthTextField", value);
			}
		}
		
		[MonoTouch.Foundation.Connect("_messageTextField")]
		private MonoTouch.UIKit.UITextField _messageTextField {
			get {
				this.__mt__messageTextField = ((MonoTouch.UIKit.UITextField)(this.GetNativeField("_messageTextField")));
				return this.__mt__messageTextField;
			}
			set {
				this.__mt__messageTextField = value;
				this.SetNativeField("_messageTextField", value);
			}
		}
	}
}

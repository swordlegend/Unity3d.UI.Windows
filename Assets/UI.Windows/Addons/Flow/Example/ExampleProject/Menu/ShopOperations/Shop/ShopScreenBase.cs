//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by the UI.Windows Flow Addon.
//     You may not edit this file because of it's auto-generated by FlowCompiler.
//     See more: https://github.com/chromealex/Unity3d.UI.Windows
// </auto-generated>
//------------------------------------------------------------------------------
using UnityEngine;
using UnityEngine.UI.Windows;
using UnityEngine.UI.Windows.Types;

namespace ExampleProject.UI.Menu.ShopOperations.Shop {

	public class ShopScreenBase : LayoutWindowType {
		
		/// <summary>
		/// Flows to the GameTypeChooser.
		/// Full Name: ExampleProject.UI.Menu.GameTypeChooser.GameTypeChooserScreen
		/// </summary>
		/// <returns>GameTypeChooser</returns>
		public virtual ExampleProject.UI.Menu.GameTypeChooser.GameTypeChooserScreen FlowGameTypeChooser(params object[] parameters) {
			
			var instance = WindowSystem.Show<ExampleProject.UI.Menu.GameTypeChooser.GameTypeChooserScreen>(parameters);
			instance.SetFunctionIterationIndex(this.GetFunctionIterationIndex());
			
			return instance;
			
		}
		
	}

}
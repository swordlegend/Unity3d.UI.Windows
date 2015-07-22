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

namespace ExampleProject.UI.Menu.GameTypeChooser {

	public class GameTypeChooserScreenBase : LayoutWindowType {
		
		/// <summary>
		/// Flows to the Shop.
		/// Full Name: ExampleProject.UI.Menu.ShopOperations.Shop.ShopScreen
		/// </summary>
		/// <returns>Shop</returns>
		public virtual ExampleProject.UI.Menu.ShopOperations.Shop.ShopScreen FlowShop(params object[] parameters) {
			
			var instance = WindowSystem.Show<ExampleProject.UI.Menu.ShopOperations.Shop.ShopScreen>(parameters);
			instance.SetFunctionIterationIndex(this.GetFunctionIterationIndex());
			
			return instance;
			
		}
				
		public class FlowFunctionLoaderRoutes : WindowRoutes {
			
			public FlowFunctionLoaderRoutes(int index) : base(index) {}
			
					
			/// <summary>
			/// Flows to the GameplayView.
			/// Full Name: ExampleProject.UI.Gameplay.GameplayView.GameplayViewScreen
			/// </summary>
			/// <returns>GameplayView</returns>
			public virtual ExampleProject.UI.Gameplay.GameplayView.GameplayViewScreen FlowGameplayView(params object[] parameters) {
				
				var instance = WindowSystem.Show<ExampleProject.UI.Gameplay.GameplayView.GameplayViewScreen>(parameters);
				instance.SetFunctionIterationIndex(this.GetFunctionIterationIndex());
				
				return instance;
				
			}
			
		}
		
		/// <summary>
		/// Call the Function Loader.
		/// Function: Loading
		/// </summary>
		/// <returns>Function root window</returns>
		public virtual ExampleProject.UI.Loader.Loading.LoadingScreen FlowFunctionLoader(UnityEngine.Events.UnityAction<FlowFunctionLoaderRoutes> onFunctionEnds, params object[] parameters) {
			
			var functionRoot = WindowSystem.Show<ExampleProject.UI.Loader.Loading.LoadingScreen>(parameters);
			WindowSystem.RegisterFunctionCallback(functionRoot, (index) => { onFunctionEnds(new FlowFunctionLoaderRoutes(index)); });
			
			return functionRoot;
			
		}

	}

}
// Copyright (c) .NET Foundation and Contributors (https://dotnetfoundation.org/ & https://stride3d.net) and Silicon Studio Corp. (https://www.siliconstudio.co.jp)
// Distributed under the MIT license. See the LICENSE.md file in the project root for more information.
using Stride.Core.Assets.Editor.ViewModel;
using Stride.Assets.Presentation.AssetEditors.UIEditor.ViewModels;
using Stride.Assets.Presentation.AssetEditors.UIEditor.Views;
using Stride.Assets.Presentation.AssetEditors.UILibraryEditor.ViewModels;
using Stride.Assets.Presentation.ViewModel;

namespace Stride.Assets.Presentation.AssetEditors.UILibraryEditor.Views
{
    public class UILibraryEditorView : UIEditorView
    {
        protected override UIEditorBaseViewModel CreateEditorViewModel(AssetViewModel asset)
        {
            return UILibraryEditorViewModel.Create((UILibraryViewModel)asset);
        }
    }
}

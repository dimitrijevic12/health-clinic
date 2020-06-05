using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls.Primitives;

namespace health_clinicClassDiagram.View
{
    public class MyDropDownButton : Xceed.Wpf.Toolkit.DropDownButton
    {
        public override void OnApplyTemplate()
        {
            base.OnApplyTemplate();

            var popup = (Popup)Template.FindName("PART_Popup", this);
            popup.Placement = PlacementMode.Custom;
            popup.CustomPopupPlacementCallback = popup.CustomPopupPlacementCallback += (Size popupSize, Size targetSize, Point offset) =>
            new[] { new CustomPopupPlacement() { Point = new Point(targetSize.Width - popupSize.Width, targetSize.Height) } };
        }
    }
}

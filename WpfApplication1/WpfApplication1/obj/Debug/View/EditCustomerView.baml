   M S B A M L   `   `   `  ����J  FWpfApplication1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:WpfApplication1WpfApplication1  5      E'clr-namespace:WpfApplication1.ViewModelWpfApplication1.ViewModel  5      +    %WpfApplication1.View.EditCustomerView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      a ]DevExpress.Xpf.Core.v15.2, Version=15.2.9.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a] YDevExpress.Mvvm.v15.2, Version=15.2.9.0, Culture=neutral, PublicKeyToken=b88d1754d700e49aAdxmvvm2http://schemas.devexpress.com/winfx/2008/xaml/mvvm   5      j fDevExpress.Xpf.LayoutControl.v15.2, Version=15.2.9.0, Culture=neutral, PublicKeyToken=b88d1754d700e49aFdxlc;http://schemas.devexpress.com/winfx/2008/xaml/layoutcontrol  5      f bDevExpress.Xpf.Grid.v15.2.Core, Version=15.2.9.0, Culture=neutral, PublicKeyToken=b88d1754d700e49aa	 ]DevExpress.Xpf.Grid.v15.2, Version=15.2.9.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a>dxg2http://schemas.devexpress.com/winfx/2008/xaml/grid  	 5      ;dx2http://schemas.devexpress.com/winfx/2008/xaml/core  5	      ?dxe5http://schemas.devexpress.com/winfx/2008/xaml/editors  5
      )localclr-namespace:WpfApplication1  5      7	viewModel'clr-namespace:WpfApplication1.ViewModel  5        � DataContext  5      1  +DevExpress.Mvvm.UI.ViewModelSourceExtension     Type5   /WpfApplication1.ViewModel.EditCustomerViewModel"   � 	Resources 5         LayoutItemStyle �� 
TargetType-  'DevExpress.Xpf.LayoutControl.LayoutItem �� Property �� Value��%X   &	        �� 5   
   "  6(   .�5      ��  � ��$	 200��6)   67   5      5      .��5      0  *DevExpress.Xpf.LayoutControl.LayoutControl  .  (DevExpress.Xpf.LayoutControl.LayoutGroup   Orientation$ Vertical=�6   .+�5   
        Label$ Name:��6   #��[  5         Content. 5      %  DevExpress.Xpf.Editors.TextEdit  	   Mask$	 
[^0-9]{1,}��5      
   MaskType$
 RegEx=�5      %  DevExpress.Xpf.Editors.BaseEdit   	EditValue 5      �� *Name+5   .   5        5   
   $ Surname:��6   #��[  5      . 5        $	 
[^0-9]{1,}��5       $
 RegEx=�5!       5      �� *	Surname+5!   .   5"        5#   
   $ Date of birth:��6   #��[  5$      . 5%      %  DevExpress.Xpf.Editors.DateEdit  '	  !DevExpress.Xpf.Editors.ButtonEdit 	  IsTextEditable$ FalseX�5&       5%      �� *DateOfBirth+5&   4   5'        5(   
   $ Adress:��6   #��[  5)      . 5*         6   �� *Adress+6:   5+        5,   
   $ City:��6   #��[  5-      . 5.        $	 
[^0-9]{1,}��5/      $
 RegEx=�50       5.      �� *City+50   .   51        52   
   $ Postal code:��6   #��[  53      . 54        $	 [0-9]{2}[-]{1}[0-9]{3}��55      $
 RegEx=�56       54      �� *
PostalCode+56   .   57        58   
   $ Phone number:��6   #��[  59      . 5:        $	 [0-9]{9}��5;      $
 RegEx=�5<       5:      �� *PhoneNumber+5<   .   5=        5>   
   $ E-mail:��6   #��[  5?      . 5@         6   �� *Email+69   5A        5B   
   $ Value:��6   #��[  5C      . 5D        $	 	[0-9]{1,}��5E      $
 RegEx=�5F       5D      �� *Value+5F   .   5G      5H      5I      
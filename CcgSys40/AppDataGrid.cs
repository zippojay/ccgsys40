﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using MaterialDesignThemes.Wpf;

namespace CcgSys40
{
    /// <summary>
    /// 按照步骤 1a 或 1b 操作，然后执行步骤 2 以在 XAML 文件中使用此自定义控件。
    ///
    /// 步骤 1a) 在当前项目中存在的 XAML 文件中使用该自定义控件。
    /// 将此 XmlNamespace 特性添加到要使用该特性的标记文件的根 
    /// 元素中: 
    ///
    ///     xmlns:MyNamespace="clr-namespace:CcgSys40"
    ///
    ///
    /// 步骤 1b) 在其他项目中存在的 XAML 文件中使用该自定义控件。
    /// 将此 XmlNamespace 特性添加到要使用该特性的标记文件的根 
    /// 元素中: 
    ///
    ///     xmlns:MyNamespace="clr-namespace:CcgSys40;assembly=CcgSys40"
    ///
    /// 您还需要添加一个从 XAML 文件所在的项目到此项目的项目引用，
    /// 并重新生成以避免编译错误: 
    ///
    ///     在解决方案资源管理器中右击目标项目，然后依次单击
    ///     “添加引用”->“项目”->[浏览查找并选择此项目]
    ///
    ///
    /// 步骤 2)
    /// 继续操作并在 XAML 文件中使用控件。
    ///
    ///     <MyNamespace:AppDataGrid/>
    ///
    /// </summary>
    public class AppDataGrid : DataGrid
    {
        static AppDataGrid()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(AppDataGrid), new FrameworkPropertyMetadata(typeof(AppDataGrid)));            
        }
        public AppDataGrid()
        {
            Style headerstyle = new Style();
            Style basestyle =   this.FindResource("MaterialDesignDataGridColumnHeader") as Style;
            headerstyle.BasedOn = basestyle;
            headerstyle.Setters.Add(new Setter(BorderThicknessProperty, new Thickness(1)));
            this.ColumnHeaderStyle = headerstyle;
        }
        public override void OnApplyTemplate()
        {
            base.OnApplyTemplate();
            //DataGrid dg = GetTemplateChild("maindg") as DataGrid;
            //List<testdata> list = new List<testdata>();
            //list.Add(new testdata { field1 = "testdata" ,field2= "testdata12testdata12testdata12testdata12testdata12testdata12testdata12testdata12testdata12testdata12testdata12testdata12" });
            //dg.ItemsSource = list;
            
        }

    }
    public class testdata
    {
        public string field1 { get; set; }
        public string field2 { get; set; }
    }
}

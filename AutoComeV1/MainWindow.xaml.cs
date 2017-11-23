﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
using System.Windows.Threading;

namespace AutoComeV1
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        //int i = 0;
        String[,] operations = new String[20, 2];
        String[] steps = new String[6];
        String newOperationTXT = "";
        String subOperation = "";
        String subTarget = " ";

        public MainWindow()
        {
            InitializeComponent();
            operateButton.Visibility = Visibility.Hidden;
            settingButton.Visibility = Visibility.Hidden;
            //showMenu(4);
            //for (int i = 0; i < 20; i++)
            //{
            //    for (int j = 0; j < 2; j++)
            //    {
            //        operations[i,j] = "Null";
            //    }
            //}
            //operations = passedOperations;
        }
       
        //Color color = Color.FromArgb(50, 0, 0, 255);
        SolidColorBrush selectBrush = new SolidColorBrush(Color.FromArgb(30, 0, 0, 255));
        SolidColorBrush predictBrush = new SolidColorBrush(Color.FromArgb(70,0, 255, 0));

        private void DoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (e.Source == button0) {
                addToOperationList("Open PDF File A", "0");
                PDF pdf = new PDF(0, operations);
               
                pdf.Check += value => subOperation=value;
                pdf.CheckTarget += value => subTarget = value;
                //addToOperationList(subOperation, subTarget);

                pdf.Show();
                pdf.Activate();
                pdf.Focus();
                pdf.Topmost = true;
                
                
            } 
            else if (e.Source == button1)
            {
                addToOperationList("Open PDF File A", "1");
                PDF pdf = new PDF(1, operations);
             
                pdf.Check += value => subOperation = value;
                pdf.CheckTarget += value => subTarget = value;
                //addToOperationList(subOperation, subTarget);
                pdf.Show();
                pdf.Activate();
                pdf.Focus();
                pdf.Topmost = true;
                
            }
            else if (e.Source == button2)
            {
                addToOperationList("Open PDF File A", "2");
                PDF pdf = new PDF(2, operations);
               
                pdf.Check += value => subOperation = value;
                pdf.CheckTarget += value => subTarget = value;
                //addToOperationList(subOperation, subTarget);
                pdf.Show();
                pdf.Activate();
                pdf.Focus();
                pdf.Topmost = true;
                
            }
            else if (e.Source == button3)
            {
                addToOperationList("Open PDF File A", "3");
                PDF pdf = new PDF(3, operations);
            
                pdf.Check += value => subOperation = value;
                pdf.CheckTarget += value => subTarget = value;
                //addToOperationList(subOperation, subTarget);
                pdf.Show();
                pdf.Activate();
                pdf.Focus();
                pdf.Topmost = true;
                
            }
            else if (e.Source == button4)
            {
                addToOperationList("Open PDF File A", "4");
                PDF pdf = new PDF(4, operations);
             
                pdf.Check += value => subOperation = value;
                pdf.CheckTarget += value => subTarget = value;
                //addToOperationList(subOperation, subTarget);
                pdf.Show();
                pdf.Activate();
                pdf.Focus();
                pdf.Topmost = true;
                
            }
            else if (e.Source == button5)
            {
                addToOperationList("Open PDF File A", "5");
                PDF pdf = new PDF(5, operations);
         
                pdf.Check += value => subOperation = value;
                pdf.CheckTarget += value => subTarget = value;
                //addToOperationList(subOperation, subTarget);
                pdf.Show();
                pdf.Activate();
                pdf.Focus();
                pdf.Topmost = true;
                
            }

            else if (e.Source == button6)
            {
                addToOperationList("Open PDF File A", "6");
                PDF pdf = new PDF(6, operations);
             
                pdf.Check += value => subOperation = value;
                pdf.CheckTarget += value => subTarget = value;
                //addToOperationList(subOperation, subTarget);
                pdf.Show();
                pdf.Activate();
                pdf.Focus();
                pdf.Topmost = true;
                
            }
            else if (e.Source == button7)
            {
                addToOperationList("Open PDF File A", "7");
                PDF pdf = new PDF(7, operations);
        
                pdf.Check += value => subOperation = value;
                pdf.CheckTarget += value => subTarget = value;
                //addToOperationList(subOperation, subTarget);
                pdf.Show();
                pdf.Activate();
                pdf.Focus();
                pdf.Topmost = true;
                
            }
            else if (e.Source == button8)
            {
                addToOperationList("Open PDF File A", "8");
                PDF pdf = new PDF(8, operations);
          
                pdf.Check += value => subOperation = value;
                pdf.CheckTarget += value => subTarget = value;
                //addToOperationList(subOperation, subTarget);
                pdf.Show();
                pdf.Activate();
                pdf.Focus();
                pdf.Topmost = true;
                
            }
            else if (e.Source == button9)
            {
                addToOperationList("Open PDF File A", "9");
                PDF pdf = new PDF(9, operations);
         
                pdf.Check += value => subOperation = value;
                pdf.CheckTarget += value => subTarget = value;
                //addToOperationList(subOperation, subTarget);
                pdf.Show();
                pdf.Activate();
                pdf.Focus();
                pdf.Topmost = true;
                
            }
            else 
            {
                addToOperationList("Open TXT File", "Untitiled");
                Text txt = new Text();

                txt.TXTcheck += value => newOperationTXT = value;

                //Console.WriteLine("******"+newOperationTXT);
                txt.Show();
                txt.Activate();
                txt.Focus();
                txt.Topmost = true;
                //addToOperationList(newOperationTXT, "Untitiled.txt");
            }
            //for (int i = 0; i < 20; i++)
            //{
            //    for (int j = 0; j < 2; j++)
            //    {
            //        if (operations[i, j] != "Null")
            //        {
            //            Console.Write(operations[i, j]+"; ");

            //        }


            //    }
            //}
            //Console.WriteLine();
            //back0.Fill = Brushes.Black;
            //PDF pdf = new PDF();
            //pdf.Show();
            //pdf.Activate();
            //pdf.Focus();
            //pdf.Topmost = true;
            //{
            //    i += 1;
            //    DispatcherTimer timer = new DispatcherTimer();
            //    timer.Interval = new TimeSpan(0, 0, 0, 0, 300);
            //    timer.Tick += (s, e1) => { timer.IsEnabled = false; i = 0; };
            //    timer.IsEnabled = true;
            //    if (i == 2)
            //    {
            //        timer.IsEnabled = false;
            //        i = 0;
            //        /*button0.Background = myBrush;*/
            //    }
            //}
        }

        private void Click(object sender, RoutedEventArgs e)
        {
            if (e.Source == button0)
            {
                
                if ((Keyboard.Modifiers & ModifierKeys.Control) == ModifierKeys.Control)
                {
                    back0.Fill = selectBrush;
                    addToOperationList("Select", "A1.pdf");
                }
                else
                {
                    back0.Fill = selectBrush;
                    back1.Fill = Brushes.Transparent;
                    back2.Fill = Brushes.Transparent;
                    back3.Fill = Brushes.Transparent;
                    back4.Fill = Brushes.Transparent;
                    back5.Fill = Brushes.Transparent;
                    back6.Fill = Brushes.Transparent;
                    back7.Fill = Brushes.Transparent;
                    back8.Fill = Brushes.Transparent;
                    back9.Fill = Brushes.Transparent;
                    back10.Fill = Brushes.Transparent;
                }
            }
            else if (e.Source == button1)
            {
                if ((Keyboard.Modifiers & ModifierKeys.Control) == ModifierKeys.Control)
                {
                    back1.Fill = selectBrush;
                    addToOperationList("Select", "A2.pdf");
                }
                else
                {
                    back0.Fill = Brushes.Transparent;
                    back1.Fill = selectBrush;
                    back2.Fill = Brushes.Transparent;
                    back3.Fill = Brushes.Transparent;
                    back4.Fill = Brushes.Transparent;
                    back5.Fill = Brushes.Transparent;
                    back6.Fill = Brushes.Transparent;
                    back7.Fill = Brushes.Transparent;
                    back8.Fill = Brushes.Transparent;
                    back9.Fill = Brushes.Transparent;
                    back10.Fill = Brushes.Transparent;
                }
            }
            else if (e.Source == button2)
            {
                if ((Keyboard.Modifiers & ModifierKeys.Control) == ModifierKeys.Control)
                {
                    back2.Fill = selectBrush;
                    addToOperationList("Select", "A3.pdf");
                }
                else
                {
                    back0.Fill = Brushes.Transparent;
                    back1.Fill = Brushes.Transparent;
                    back2.Fill = selectBrush;
                    back3.Fill = Brushes.Transparent;
                    back4.Fill = Brushes.Transparent;
                    back5.Fill = Brushes.Transparent;
                    back6.Fill = Brushes.Transparent;
                    back7.Fill = Brushes.Transparent;
                    back8.Fill = Brushes.Transparent;
                    back9.Fill = Brushes.Transparent;
                    back10.Fill = Brushes.Transparent;
                }
            }
            else if (e.Source == button3)
            {
                if ((Keyboard.Modifiers & ModifierKeys.Control) == ModifierKeys.Control)
                {
                    back3.Fill = selectBrush;
                    addToOperationList("Select", "A4.pdf");
                }
                else
                {
                    back0.Fill = Brushes.Transparent;
                    back1.Fill = Brushes.Transparent;
                    back2.Fill = Brushes.Transparent;
                    back3.Fill = selectBrush;
                    back4.Fill = Brushes.Transparent;
                    back5.Fill = Brushes.Transparent;
                    back6.Fill = Brushes.Transparent;
                    back7.Fill = Brushes.Transparent;
                    back8.Fill = Brushes.Transparent;
                    back9.Fill = Brushes.Transparent;
                    back10.Fill = Brushes.Transparent;
                }
            }
            else if (e.Source == button4)
            {
                if ((Keyboard.Modifiers & ModifierKeys.Control) == ModifierKeys.Control)
                {
                    back4.Fill = selectBrush;
                    addToOperationList("Select", "A5.pdf");
                }
                else
                {
                    back0.Fill = Brushes.Transparent;
                    back1.Fill = Brushes.Transparent;
                    back2.Fill = Brushes.Transparent;
                    back3.Fill = Brushes.Transparent;
                    back4.Fill = selectBrush;
                    back5.Fill = Brushes.Transparent;
                    back6.Fill = Brushes.Transparent;
                    back7.Fill = Brushes.Transparent;
                    back8.Fill = Brushes.Transparent;
                    back9.Fill = Brushes.Transparent;
                    back10.Fill = Brushes.Transparent;
                }
            }
            else if (e.Source == button5)
            {
                if ((Keyboard.Modifiers & ModifierKeys.Control) == ModifierKeys.Control)
                {
                    back5.Fill = selectBrush;
                    addToOperationList("Select", "A6.pdf");
                }
                else
                {
                    back0.Fill = Brushes.Transparent;
                    back1.Fill = Brushes.Transparent;
                    back2.Fill = Brushes.Transparent;
                    back3.Fill = Brushes.Transparent;
                    back4.Fill = Brushes.Transparent;
                    back5.Fill = selectBrush;
                    back6.Fill = Brushes.Transparent;
                    back7.Fill = Brushes.Transparent;
                    back8.Fill = Brushes.Transparent;
                    back9.Fill = Brushes.Transparent;
                    back10.Fill = Brushes.Transparent;
                }
            }
            else if (e.Source == button6)
            {
                if ((Keyboard.Modifiers & ModifierKeys.Control) == ModifierKeys.Control)
                {
                    back6.Fill = selectBrush;
                    addToOperationList("Select", "A7.pdf");
                }
                else
                {
                    back0.Fill = Brushes.Transparent;
                    back1.Fill = Brushes.Transparent;
                    back2.Fill = Brushes.Transparent;
                    back3.Fill = Brushes.Transparent;
                    back4.Fill = Brushes.Transparent;
                    back5.Fill = Brushes.Transparent;
                    back6.Fill = selectBrush;
                    back7.Fill = Brushes.Transparent;
                    back8.Fill = Brushes.Transparent;
                    back9.Fill = Brushes.Transparent;
                    back10.Fill = Brushes.Transparent;
                }
            }
            else if (e.Source == button7)
            {
                if ((Keyboard.Modifiers & ModifierKeys.Control) == ModifierKeys.Control)
                {
                    back7.Fill = selectBrush;
                    addToOperationList("Select", "A8.pdf");
                }
                else
                {
                    back0.Fill = Brushes.Transparent;
                    back1.Fill = Brushes.Transparent;
                    back2.Fill = Brushes.Transparent;
                    back3.Fill = Brushes.Transparent;
                    back4.Fill = Brushes.Transparent;
                    back5.Fill = Brushes.Transparent;
                    back6.Fill = Brushes.Transparent;
                    back7.Fill = selectBrush;
                    back8.Fill = Brushes.Transparent;
                    back9.Fill = Brushes.Transparent;
                    back10.Fill = Brushes.Transparent;
                }
            }

            else if (e.Source == button8)
            {
                if ((Keyboard.Modifiers & ModifierKeys.Control) == ModifierKeys.Control)
                {
                    back8.Fill = selectBrush;
                    addToOperationList("Select", "A9.pdf");
                }
                else
                {
                    back0.Fill = Brushes.Transparent;
                    back1.Fill = Brushes.Transparent;
                    back2.Fill = Brushes.Transparent;
                    back3.Fill = Brushes.Transparent;
                    back4.Fill = Brushes.Transparent;
                    back5.Fill = Brushes.Transparent;
                    back6.Fill = Brushes.Transparent;
                    back7.Fill = Brushes.Transparent;
                    back8.Fill = selectBrush;
                    back9.Fill = Brushes.Transparent;
                    back10.Fill = Brushes.Transparent;
                }
            }
            else if (e.Source == button9)
            {
                if ((Keyboard.Modifiers & ModifierKeys.Control) == ModifierKeys.Control)
                {
                    back9.Fill = selectBrush;
                    addToOperationList("Select", "A10.pdf");
                }
                else
                {
                    back0.Fill = Brushes.Transparent;
                    back1.Fill = Brushes.Transparent;
                    back2.Fill = Brushes.Transparent;
                    back3.Fill = Brushes.Transparent;
                    back4.Fill = Brushes.Transparent;
                    back5.Fill = Brushes.Transparent;
                    back6.Fill = Brushes.Transparent;
                    back7.Fill = Brushes.Transparent;
                    back8.Fill = Brushes.Transparent;
                    back9.Fill = selectBrush;
                    back10.Fill = Brushes.Transparent;
                }
                
            }
            else if (e.Source == button10)
            {
                if ((Keyboard.Modifiers & ModifierKeys.Control) == ModifierKeys.Control)
                {
                    back10.Fill = selectBrush;
                    addToOperationList("Select", "Untitled.pdf");
                }
                else
                {
                    back0.Fill = Brushes.Transparent;
                    back1.Fill = Brushes.Transparent;
                    back2.Fill = Brushes.Transparent;
                    back3.Fill = Brushes.Transparent;
                    back4.Fill = Brushes.Transparent;
                    back5.Fill = Brushes.Transparent;
                    back6.Fill = Brushes.Transparent;
                    back7.Fill = Brushes.Transparent;
                    back8.Fill = Brushes.Transparent;
                    back9.Fill = Brushes.Transparent;
                    back10.Fill = selectBrush;
                }

            }
            else
            {
                addToOperationList("Unselect", "All");
                back0.Fill = Brushes.Transparent;
                back1.Fill = Brushes.Transparent;
                back2.Fill = Brushes.Transparent;
                back3.Fill = Brushes.Transparent;
                back4.Fill = Brushes.Transparent;
                back5.Fill = Brushes.Transparent;
                back6.Fill = Brushes.Transparent;
                back7.Fill = Brushes.Transparent;
                back8.Fill = Brushes.Transparent;
                back9.Fill = Brushes.Transparent;
                back10.Fill = Brushes.Transparent;
            }

            //for (int i = 0; i < 20; i++)
            //{
            //    for (int j = 0; j < 2; j++)
            //    {
            //        if (operations[i, j] != "Null")
            //        {
            //            Console.Write(operations[i, j]);

            //        }


            //    }
            //}
            //Console.WriteLine();

        }

        private void ApplyClick(object sender, RoutedEventArgs e)
        {
           //TO-DO：automatically copy all
        }

        private void SettingClick(object sender, RoutedEventArgs e)
        {
            //TO-DO: create instence based on the list of actions detected.
            Settings newSettings = new Settings(steps[0], steps[1], steps[2], steps[3], steps[4], steps[5]);
            newSettings.Show();
            newSettings.Activate();
            newSettings.Focus();
            newSettings.Topmost = true;
        }

        private void addToOperationList(String newOperaton, String newTarget)
        {
            for (int i = 0; i < 19; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    operations[i,j] = operations[i + 1,j];
                }
                
            }
            operations[19,0] = newOperaton;
            operations[19, 1] = newTarget;
        }

        private void showMenu(int predictTarget)
        {
            if (predictTarget == 0)
            {
                operateButton.Margin = new Thickness(287, 303, 0, 0);
                settingButton.Margin = new Thickness(287, 346, 0, 0);
                active0.Fill = predictBrush;
                active1.Fill = Brushes.Transparent;
                active2.Fill = Brushes.Transparent;
                active3.Fill = Brushes.Transparent;
                active4.Fill = Brushes.Transparent;
                active5.Fill = Brushes.Transparent;
                active6.Fill = Brushes.Transparent;
                active7.Fill = Brushes.Transparent;
                active8.Fill = Brushes.Transparent;
                active9.Fill = Brushes.Transparent;
                active10.Fill = Brushes.Transparent;


            }
            else if (predictTarget == 1)
            {
                operateButton.Margin = new Thickness(436, 303, 0, 0);
                settingButton.Margin = new Thickness(436, 346, 0, 0);
                active1.Fill = predictBrush;
                active0.Fill = Brushes.Transparent;
                active2.Fill = Brushes.Transparent;
                active3.Fill = Brushes.Transparent;
                active4.Fill = Brushes.Transparent;
                active5.Fill = Brushes.Transparent;
                active6.Fill = Brushes.Transparent;
                active7.Fill = Brushes.Transparent;
                active8.Fill = Brushes.Transparent;
                active9.Fill = Brushes.Transparent;
                active10.Fill = Brushes.Transparent;
            }
            else if (predictTarget ==2)
            {
                operateButton.Margin = new Thickness(590, 303, 0, 0);
                settingButton.Margin = new Thickness(590, 346, 0, 0);
                active2.Fill = predictBrush;
                active1.Fill = Brushes.Transparent;
                active0.Fill = Brushes.Transparent;
                active3.Fill = Brushes.Transparent;
                active4.Fill = Brushes.Transparent;
                active5.Fill = Brushes.Transparent;
                active6.Fill = Brushes.Transparent;
                active7.Fill = Brushes.Transparent;
                active8.Fill = Brushes.Transparent;
                active9.Fill = Brushes.Transparent;
                active10.Fill = Brushes.Transparent;
            }
            else if (predictTarget ==3)
            {
                operateButton.Margin = new Thickness(740, 303, 0, 0);
                settingButton.Margin = new Thickness(740, 346, 0, 0);
                active3.Fill = predictBrush;
                active1.Fill = Brushes.Transparent;
                active2.Fill = Brushes.Transparent;
                active0.Fill = Brushes.Transparent;
                active4.Fill = Brushes.Transparent;
                active5.Fill = Brushes.Transparent;
                active6.Fill = Brushes.Transparent;
                active7.Fill = Brushes.Transparent;
                active8.Fill = Brushes.Transparent;
                active9.Fill = Brushes.Transparent;
                active10.Fill = Brushes.Transparent;
            }
            else if (predictTarget == 4)
            {
                operateButton.Margin = new Thickness(886, 303, 0, 0);
                settingButton.Margin = new Thickness(886, 346, 0, 0);
                active4.Fill = predictBrush;
                active1.Fill = Brushes.Transparent;
                active2.Fill = Brushes.Transparent;
                active3.Fill = Brushes.Transparent;
                active0.Fill = Brushes.Transparent;
                active5.Fill = Brushes.Transparent;
                active6.Fill = Brushes.Transparent;
                active7.Fill = Brushes.Transparent;
                active8.Fill = Brushes.Transparent;
                active9.Fill = Brushes.Transparent;
                active10.Fill = Brushes.Transparent;
            }
            else if (predictTarget == 5)
            {
                operateButton.Margin = new Thickness(1040, 303, 0, 0);
                settingButton.Margin = new Thickness(1040, 346, 0, 0);
                active5.Fill = predictBrush;
                active1.Fill = Brushes.Transparent;
                active2.Fill = Brushes.Transparent;
                active3.Fill = Brushes.Transparent;
                active4.Fill = Brushes.Transparent;
                active0.Fill = Brushes.Transparent;
                active6.Fill = Brushes.Transparent;
                active7.Fill = Brushes.Transparent;
                active8.Fill = Brushes.Transparent;
                active9.Fill = Brushes.Transparent;
                active10.Fill = Brushes.Transparent;
            }
            else if (predictTarget == 6)
            {
                operateButton.Margin = new Thickness(1188, 303, 0, 0);
                settingButton.Margin = new Thickness(1188, 346, 0, 0);
                active6.Fill = predictBrush;
                active1.Fill = Brushes.Transparent;
                active2.Fill = Brushes.Transparent;
                active3.Fill = Brushes.Transparent;
                active4.Fill = Brushes.Transparent;
                active5.Fill = Brushes.Transparent;
                active0.Fill = Brushes.Transparent;
                active7.Fill = Brushes.Transparent;
                active8.Fill = Brushes.Transparent;
                active9.Fill = Brushes.Transparent;
                active10.Fill = Brushes.Transparent;
            }
            else if (predictTarget == 7)
            {
                operateButton.Margin = new Thickness(1328, 303, 0, 0);
                settingButton.Margin = new Thickness(1328, 346, 0, 0);
                active7.Fill = predictBrush;
                active1.Fill = Brushes.Transparent;
                active2.Fill = Brushes.Transparent;
                active3.Fill = Brushes.Transparent;
                active4.Fill = Brushes.Transparent;
                active5.Fill = Brushes.Transparent;
                active6.Fill = Brushes.Transparent;
                active0.Fill = Brushes.Transparent;
                active8.Fill = Brushes.Transparent;
                active9.Fill = Brushes.Transparent;
                active10.Fill = Brushes.Transparent;
            }
            else if (predictTarget ==8)
            {
                operateButton.Margin = new Thickness(287, 451, 0, 0);
                settingButton.Margin = new Thickness(287, 494, 0, 0);
                active8.Fill = predictBrush;
                active1.Fill = Brushes.Transparent;
                active2.Fill = Brushes.Transparent;
                active3.Fill = Brushes.Transparent;
                active4.Fill = Brushes.Transparent;
                active5.Fill = Brushes.Transparent;
                active6.Fill = Brushes.Transparent;
                active7.Fill = Brushes.Transparent;
                active0.Fill = Brushes.Transparent;
                active9.Fill = Brushes.Transparent;
                active10.Fill = Brushes.Transparent;
            }
            else if (predictTarget == 9)
            {
                operateButton.Margin = new Thickness(436, 451, 0, 0);
                settingButton.Margin = new Thickness(436, 494, 0, 0);
                active9.Fill = predictBrush;
                active1.Fill = Brushes.Transparent;
                active2.Fill = Brushes.Transparent;
                active3.Fill = Brushes.Transparent;
                active4.Fill = Brushes.Transparent;
                active5.Fill = Brushes.Transparent;
                active6.Fill = Brushes.Transparent;
                active7.Fill = Brushes.Transparent;
                active8.Fill = Brushes.Transparent;
                active0.Fill = Brushes.Transparent;
                active10.Fill = Brushes.Transparent;
            }

        }

        private void MainActivated(object sender, EventArgs e)
        {
            if (subOperation != " " && subOperation != " ")
            {
                addToOperationList(subOperation, subTarget);
                subOperation = " ";
                subOperation = " ";

            }
            if (newOperationTXT!=" ")
            {
                addToOperationList(newOperationTXT, "Untitiled.txt");
                newOperationTXT = " ";
            }

            CheckPattern();
            //Console.WriteLine(newOperationTXT);
            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    if (operations[i, j] != "Null")
                    {
                        Console.Write(operations[i, j]+"; ");

                    }


                }
            }
            Console.WriteLine();
        }

        private void CheckPattern()
        {
            Boolean operationFlag = false;
            int difference = 0;
            int largestStep = 0;
            for (int i = 6; i >1; i--) {
                for (int j = 0; j< i; j++)
                {
                    if (operations[19 - j, 0] == operations[19 - i - j, 0])
                    {
                        operationFlag = true;
                        if (operations[19 - j, 0] == "Open PDF File A")
                        {
                            difference = int.Parse(operations[19 - j, 1])+int.Parse(operations[19 - j, 1]) - int.Parse(operations[19 -i -j, 1]);
                        }    
                    }
                    else
                    {
                        operationFlag = false;
                    }
                    Console.WriteLine("*"+operationFlag);
                }
                if (operationFlag == true&&difference!=0)
                {
                    largestStep = i + 1;
                    Console.WriteLine(i + "***" + operationFlag);
                    Console.WriteLine(difference + "***" );
                    for (int x = 0; x < largestStep-1; x++)
                    {
                        if (Regex.IsMatch(operations[19 - x, 1], @"^[+-]?\d*$"))
                        {
                            steps[largestStep-2-x] = operations[19 - x, 0] + " "+"file";
                        }
                        else
                        {
                            steps[largestStep-2-x] = operations[19 - x, 0] + " " + operations[19 - x, 1];
                        }
                        
                    }
                    for (int y = largestStep-1; y < 6; y++)
                    {
                        steps[y] = "Null";
                    }
                    showMenu(difference);
                    //unselectButton.IsEnabled = false;
                    break;
                }
                
            }

            //if (operationFlag==true&&difference != 0)
            //{
            //    showMenu(difference);
            //}


            
           
        }
    }

}

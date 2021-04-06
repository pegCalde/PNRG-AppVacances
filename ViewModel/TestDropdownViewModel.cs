using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace PNRG-AppVacances.Model
{
    class TestDropdownViewModel
    {
        public IList<TestDropdown> StudentList { get; set; }

        public TestDropdownViewModel()
        {
            try
            {
                StudentList = new ObservableCollection<TestDropdown>();

                StudentList.Add(new TestDropdown
                {
                    IdStudent = 1,
                    NameStudent = "Savin Guillaume"
                });
                StudentList.Add(new TestDropdown
                {
                    IdStudent = 2,
                    NameStudent = "Calderon Peggy"
                });
                StudentList.Add(new TestDropdown
                {
                    IdStudent = 3,
                    NameStudent = "Tachibana Kanade"
                });
            }
            catch (Exception e)
            {

            }

        }
    }
}

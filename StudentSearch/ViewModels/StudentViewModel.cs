﻿using StudentSearch.Commands;
using StudentSearch.Models;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows;

namespace StudentSearch.ViewModels;

public class StudentViewModel : BaseViewModel
{
    private string? _fioSearch;
    public string? FioSearch
    {
        get => _fioSearch;
        set
        {
            _fioSearch = value;
            OnPropertyChanged(nameof(FioSearch));
        }
    }
    private Student? _selectedStudent;
    public Student? SelectedStudent
    {
        get => _selectedStudent;
        set
        {
            _selectedStudent = value;
            OnPropertyChanged(nameof(SelectedStudent));
        }
    }
    private ObservableCollection<Student>? _students;
    public ObservableCollection<Student>? Students
    {
        get => _students;
        set
        {
            _students = value;
            OnPropertyChanged(nameof(Students));
        }
    }
    public BaseCommand SearchCommand { get; }
    public StudentViewModel()
    {
        SearchCommand = new SearchCommand(this); 
    }
}
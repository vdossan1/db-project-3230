﻿// Author: Vitor dos Santos & Jacob Evans
// Version: Fall 2024

using System.ComponentModel;
using HealthCareApp.DAL;
using HealthCareApp.model;
using static HealthCareApp.view.AdvancedSearchControl;

namespace HealthCareApp.viewmodel.UserControlVM;

public class AppointmentsControlViewModel
{
    #region Properties

    /// <summary>
    ///     Gets the list of appointments.
    /// </summary>
    public List<Appointment> Appointments { get; private set; }

    #endregion

    #region Constructors

    /// <summary>
    ///     Initializes a new instance of the <see cref="AppointmentsControlViewModel" /> class.
    /// </summary>
    public AppointmentsControlViewModel()
    {
        Appointments = new List<Appointment>();
        PopulateAppointments();
    }

    #endregion

    #region Methods

    /// <summary>
    ///     Occurs when a property value changes.
    /// </summary>
    public event PropertyChangedEventHandler? PropertyChanged;

    /// <summary>
    ///     Populates the Appointments list with either all appointments or filtered appointments based on the provided search
    ///     criteria.
    /// </summary>
    /// <param name="eventArgs">
    ///     Optional. The <see cref="SearchEventArgs" /> containing the search criteria. If null, all
    ///     appointments are retrieved.
    /// </param>
    public void PopulateAppointments(SearchEventArgs eventArgs = null)
    {
        if (eventArgs == null)
        {
            Appointments = AppointmentDal.GetAllAppointments();
        }
        else
        {
            var firstName = eventArgs.FirstName;
            var lastName = eventArgs.LastName;
            var dateOfBirth = eventArgs.DateOfBirth;

            Appointments = AppointmentDal.GetAllAppointmentsWithParams(firstName, lastName, dateOfBirth);
        }
    }

    #endregion
}
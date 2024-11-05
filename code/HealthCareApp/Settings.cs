// Author: Vitor dos Santos & Jacob Evans
// Version: Fall 2024

namespace HealthCareApp;

/// <summary>
///     Provides global application settings that can be accessed and modified statically.
/// </summary>
public static class Settings
{
    #region Properties

    /// <summary>
    ///     Gets or sets the accent color used across the application for UI elements.
    ///     The default color is a shade of green (RGB: 60, 189, 94).
    /// </summary>
    public static Color AccentColor { get; set; } = Color.FromArgb(60, 189, 94);

    #endregion
}
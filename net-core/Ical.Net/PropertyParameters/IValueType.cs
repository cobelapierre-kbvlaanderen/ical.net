﻿namespace Ical.Net.PropertyParameters
{
    public interface IValueType
    {
        string Name { get; }
        string Value { get; }
        bool IsEmpty { get; }
        string ToString();
    }
}
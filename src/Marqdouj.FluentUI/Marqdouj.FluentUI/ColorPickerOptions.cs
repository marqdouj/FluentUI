using Microsoft.FluentUI.AspNetCore.Components;

namespace Marqdouj.FluentUI
{
    /// <summary>
    /// <see Based on: cref="https://www.fluentui-blazor.net/Combobox"/>
    /// </summary>
    public class ColorPickerOptions
    {
        /// <summary>
        /// <see cref="FluentSelect{TOption}.Appearance"/>
        /// </summary>
        public Appearance? Appearance { get; set; } = null;

        /// <summary>
        /// <see cref="FluentInputBase{TValue}.AriaLabel"/>
        /// </summary>
        /// 
        public string? AriaLabel { get; set; }

        /// <summary>
        /// <see cref="FluentInputBase{TValue}.Autofocus"/>
        /// </summary>
        public bool Autofocus { get; set; }

        /// <summary>
        /// <see cref="ListComponentBase{TOption}.ChangeOnEnterOnly"/>
        /// </summary>
        public bool ChangeOnEnterOnly { get; set; }

        /// <summary>
        /// <see cref="FluentComponentBase.Class"/>
        /// </summary>
        public string? Class { get; set; }

        /// <summary>
        /// <see cref="FluentInputBase{TValue}.Disabled"/>
        /// </summary>
        public bool Disabled { get; set; }

        /// <summary>
        /// <see cref="FluentInputBase{TValue}.DisplayName"/>
        /// </summary>
        public string? DisplayName { get; set; }

        /// <summary>
        /// <see cref="FluentInputBase{TValue}.Embedded"/>
        /// </summary>
        public bool Embedded { get; set; }

        /// <summary>
        /// <see cref="ListComponentBase{TOption}.Height"/>
        /// </summary>
        public string? Height { get; set; } = "200px";

        /// <summary>
        /// <see cref="FluentInputBase{TValue}.Immediate"/>
        /// </summary>
        public bool Immediate { get; set; }

        /// <summary>
        /// <see cref="FluentInputBase{TValue}.ImmediateDelay"/>
        /// </summary>
        public int ImmediateDelay { get; set; }

        /// <summary>
        /// <see cref="FluentInputBase{TValue}.Label"/>
        /// </summary>
        public string? Label { get; set; }

        /// <summary>
        /// <see cref="FluentInputBase{TValue}.Name"/>
        /// </summary>
        public string? Name { get; set; }

        /// <summary>
        /// <see cref="FluentSelect{TOption}.Open"/>"/>
        /// </summary>
        public bool? Open { get; set; }

        /// <summary>
        /// <see cref="FluentInputBase{TValue}.Placeholder"/>
        /// </summary>
        public string? Placeholder { get; set; }

        /// <summary>
        /// <see cref="FluentSelect{TOption}.Position"/>
        /// </summary>
        public SelectPosition Position { get; set; } = SelectPosition.Below;

        /// <summary>
        /// <see cref="FluentInputBase{TValue}.ReadOnly"/>
        /// </summary>
        public bool ReadOnly { get; set; }

        /// <summary>
        /// <see cref="FluentInputBase{TValue}.Required"/>
        /// </summary>
        public bool Required { get; set; }

        /// <summary>
        /// <see cref="FluentComponentBase.Style"/>"/>
        /// </summary>
        public string? Style { get; set; }

        /// <summary>
        /// <see cref="ListComponentBase{TOption}.Width"/>
        /// </summary>
        public string? Width { get; set; }
    }
}

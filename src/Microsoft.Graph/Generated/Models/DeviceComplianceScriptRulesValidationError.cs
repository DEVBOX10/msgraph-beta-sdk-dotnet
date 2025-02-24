// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Error code for rule validation.</summary>
    public enum DeviceComplianceScriptRulesValidationError {
        /// <summary>None error.</summary>
        [EnumMember(Value = "none")]
        None,
        /// <summary>Json file invalid error.</summary>
        [EnumMember(Value = "jsonFileInvalid")]
        JsonFileInvalid,
        /// <summary>Json file missing error.</summary>
        [EnumMember(Value = "jsonFileMissing")]
        JsonFileMissing,
        /// <summary>Json file too large error.</summary>
        [EnumMember(Value = "jsonFileTooLarge")]
        JsonFileTooLarge,
        /// <summary>Rules missing error.</summary>
        [EnumMember(Value = "rulesMissing")]
        RulesMissing,
        /// <summary>Duplicate rules error.</summary>
        [EnumMember(Value = "duplicateRules")]
        DuplicateRules,
        /// <summary>Too many rules specified error.</summary>
        [EnumMember(Value = "tooManyRulesSpecified")]
        TooManyRulesSpecified,
        /// <summary>Operator missing error.</summary>
        [EnumMember(Value = "operatorMissing")]
        OperatorMissing,
        /// <summary>Operator not supported error.</summary>
        [EnumMember(Value = "operatorNotSupported")]
        OperatorNotSupported,
        /// <summary>Data type missing error.</summary>
        [EnumMember(Value = "datatypeMissing")]
        DatatypeMissing,
        /// <summary>Data type not supported error.</summary>
        [EnumMember(Value = "datatypeNotSupported")]
        DatatypeNotSupported,
        /// <summary>Operator data type combination not supported error.</summary>
        [EnumMember(Value = "operatorDataTypeCombinationNotSupported")]
        OperatorDataTypeCombinationNotSupported,
        /// <summary>More info urlmissing error.</summary>
        [EnumMember(Value = "moreInfoUriMissing")]
        MoreInfoUriMissing,
        /// <summary>More info url invalid error.</summary>
        [EnumMember(Value = "moreInfoUriInvalid")]
        MoreInfoUriInvalid,
        /// <summary>More info ur ltoo large error.</summary>
        [EnumMember(Value = "moreInfoUriTooLarge")]
        MoreInfoUriTooLarge,
        /// <summary>Description missing error.</summary>
        [EnumMember(Value = "descriptionMissing")]
        DescriptionMissing,
        /// <summary>Description invalid error.</summary>
        [EnumMember(Value = "descriptionInvalid")]
        DescriptionInvalid,
        /// <summary>Description too large error.</summary>
        [EnumMember(Value = "descriptionTooLarge")]
        DescriptionTooLarge,
        /// <summary>Title missing error.</summary>
        [EnumMember(Value = "titleMissing")]
        TitleMissing,
        /// <summary>Title invalid error.</summary>
        [EnumMember(Value = "titleInvalid")]
        TitleInvalid,
        /// <summary>Title too large error.</summary>
        [EnumMember(Value = "titleTooLarge")]
        TitleTooLarge,
        /// <summary>Operand missing error.</summary>
        [EnumMember(Value = "operandMissing")]
        OperandMissing,
        /// <summary>Operand invalid error.</summary>
        [EnumMember(Value = "operandInvalid")]
        OperandInvalid,
        /// <summary>Operand too large error.</summary>
        [EnumMember(Value = "operandTooLarge")]
        OperandTooLarge,
        /// <summary>Setting name missing error.</summary>
        [EnumMember(Value = "settingNameMissing")]
        SettingNameMissing,
        /// <summary>Setting name invalid error.</summary>
        [EnumMember(Value = "settingNameInvalid")]
        SettingNameInvalid,
        /// <summary>Setting name too large error.</summary>
        [EnumMember(Value = "settingNameTooLarge")]
        SettingNameTooLarge,
        /// <summary>English locale missing error.</summary>
        [EnumMember(Value = "englishLocaleMissing")]
        EnglishLocaleMissing,
        /// <summary>Duplicate locales error.</summary>
        [EnumMember(Value = "duplicateLocales")]
        DuplicateLocales,
        /// <summary>Unrecognized locale error.</summary>
        [EnumMember(Value = "unrecognizedLocale")]
        UnrecognizedLocale,
        /// <summary>Unknown error.</summary>
        [EnumMember(Value = "unknown")]
        Unknown,
        /// <summary>Remediation strings missing error.</summary>
        [EnumMember(Value = "remediationStringsMissing")]
        RemediationStringsMissing,
    }
}

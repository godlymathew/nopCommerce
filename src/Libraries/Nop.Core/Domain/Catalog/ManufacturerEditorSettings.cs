using Nop.Core.Configuration;

namespace Nop.Core.Domain.Catalog
{
    public class ManufacturerEditorSettings: ISettings
    {
        /// <summary>
        /// Gets or sets a value indicating whether 'Meta keywords' field is shown
        /// </summary>
        public bool MetaKeywords { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether 'Meta description' field is shown
        /// </summary>
        public bool MetaDescription { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether 'Meta title' field is shown
        /// </summary>
        public bool MetaTitle { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether 'Se name' field is shown
        /// </summary>
        public bool SeName { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether 'Page size' field is shown
        /// </summary>
        public bool PageSize { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether 'Allow customers to select page size' field is shown
        /// </summary>
        public bool AllowCustomersToSelectPageSize { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether 'Page size options' field is shown
        /// </summary>
        public bool PageSizeOptions { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether 'Price ranges' field is shown
        /// </summary>
        public bool PriceRanges { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether 'Published' field is shown
        /// </summary>
        public bool Published { get; set; }


        /// <summary>
        /// Gets or sets a value indicating whether 'Created on' field is shown
        /// </summary>
        public bool CreatedOn { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether 'Updated on' field is shown
        /// </summary>
        public bool UpdatedOn { get; set; }
    }
}

﻿//
// This file manually written from cef/include/internal/cef_types.h.
// C API name: cef_response_filter_status_t.
//
namespace ShoppingWebCrawler.Cef.Core
{
    /// <summary>
    /// Return values for CefResponseFilter::Filter().
    /// </summary>
    public enum CefResponseFilterStatus
    {
        /// <summary>
        /// Some or all of the pre-filter data was read successfully but more data is
        /// needed in order to continue filtering (filtered output is pending).
        /// </summary>
        RESPONSE_FILTER_NEED_MORE_DATA,

        /// <summary>
        /// Some or all of the pre-filter data was read successfully and all available
        /// filtered output has been written.
        /// </summary>
        RESPONSE_FILTER_DONE,

        /// <summary>
        /// An error occurred during filtering.
        /// </summary>
        RESPONSE_FILTER_ERROR
    }
}

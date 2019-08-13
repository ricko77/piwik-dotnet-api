using System;
using System.Collections;
using System.Collections.Generic;
using Piwik.Analytics.Parameters;

/// <summary>
/// Piwik - Open source web analytics
/// For more information, see http://piwik.org
/// </summary>
namespace Piwik.Analytics.Modules
{

    /// <summary>
    /// Service Gateway for Piwik SegmentEditor Module API
    /// For more information, see http://piwik.org/docs/analytics-api/reference
    /// </summary>
    /// 
    /// <remarks>
    /// This Analytics API is tested against Piwik 3.10
    /// </remarks> 
    public class SegmentEditor : PiwikAnalytics
    {
        private const string PLUGIN = "SegmentEditor";

        protected override string getPlugin()
        {
            return PLUGIN;
        }

        /// <summary>
        /// Can user add a segment to a Site
        /// </summary>
        /// <param name="idSite"></param>
        /// <returns></returns>
        public Boolean isUserCanAddNewSegment(int idSite)
        {
            Parameter[] parameters =
            {
                new SimpleParameter("idSite", idSite),
            };

            return this.sendRequest<Boolean>("isUserCanAddNewSegment", new List<Parameter>(parameters));
        }

        /// <summary>
        /// Deletes a segment by id
        /// </summary>
        /// <param name="idSegment"></param>
        /// <returns></returns>
        public Boolean delete(int idSegment)
        {
            Parameter[] parameters =
            {
                new SimpleParameter("idSegment", idSegment),
            };

            return this.sendRequest<Boolean>("delete", new List<Parameter>(parameters));
        }

        /// <summary>
        /// Updates a segment
        /// </summary>
        /// <param name="idSegment"></param>
        /// <param name="name"></param>
        /// <param name="definition"></param>
        /// <param name="idSite"></param>
        /// <param name="autoArchive"></param>
        /// <param name="enabledAllUsers"></param>
        /// <returns></returns>
        public Boolean update(
            int idSegment,
            string name,
            string definition,
            int idSite,
            Boolean autoArchive,
            Boolean enabledAllUsers)
        {
            Parameter[] parameters =
            {
                new SimpleParameter("idSegment", idSegment),
                new SimpleParameter("name", name),
                new SimpleParameter("definition", definition),
                new SimpleParameter("idSite", idSite),
                new SimpleParameter("autoArchive", autoArchive),
                new SimpleParameter("enabledAllUsers", enabledAllUsers)
            };

            return this.sendRequest<Boolean>("update", new List<Parameter>(parameters));
        }

        /// <summary>
        /// Adds a segment
        /// </summary>
        /// <param name="name"></param>
        /// <param name="definition"></param>
        /// <param name="idSite"></param>
        /// <param name="autoArchive"></param>
        /// <param name="enabledAllUsers"></param>
        /// <returns></returns>
        public int add(
            string name,
            string definition,
            int idSite,
            Boolean autoArchive,
            Boolean enabledAllUsers)
        {
            Parameter[] parameters =
            {
                new SimpleParameter("name", name),
                new SimpleParameter("definition", definition),
                new SimpleParameter("idSite", idSite),
                new SimpleParameter("autoArchive", autoArchive),
                new SimpleParameter("enabledAllUsers", enabledAllUsers)
            };

            return this.sendRequest<int>("add", new List<Parameter>(parameters));
        }

        /// <summary>
        /// Get a specific segment
        /// </summary>
        /// <param name="idSegment"></param>
        /// <returns></returns>
        public ArrayList get(int idSegment)
        {
            Parameter[] parameters =
            {
                new SimpleParameter("idSegment", idSegment),
            };

            return this.sendRequest<ArrayList>("get", new List<Parameter>(parameters));
        }

        /// <summary>
        /// Get all segments for a Site
        /// </summary>
        /// <param name="idSite"></param>
        /// <returns></returns>
        public ArrayList getAll(int idSite)
        {
            Parameter[] parameters =
            {
                new SimpleParameter("idSite", idSite),
            };

            return this.sendRequest<ArrayList>("getAll", new List<Parameter>(parameters));
        }
    }
}

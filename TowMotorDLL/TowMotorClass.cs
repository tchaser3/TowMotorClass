/* Title:           Tow Motor Class
 * Date:            5-29-20
 * Author:          Terry Holmes
 * 
 * Description:     This is the class for Tow Motors */

using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using NewEventLogDLL;
using TowMotorDLL.FindTowMotorInspectionByDateMatchDataSetTableAdapters;

namespace TowMotorDLL
{
    public class TowMotorClass
    {
        EventLogClass TheEventLogClass = new EventLogClass();

        TowMotorMainDataSet aTowMotorMainDataSet;
        TowMotorMainDataSetTableAdapters.towmotormainTableAdapter aTowMotorMainTableAdapter;

        InsertTowMotorMainEntryTableAdapters.QueriesTableAdapter aInsertTowMotorMainTableAdapter;

        UpdateTowMotorMainActiveEntryTableAdapters.QueriesTableAdapter aUpdateTowMotorMainActiveTableAdapter;

        UpdateTowMotorMainOilChangeDateEntryTableAdapters.QueriesTableAdapter aUpdateTowMotorMainOilChangeDateTableAdapter;

        UpdateTowMotorMainHoursEntryTableAdapters.QueriesTableAdapter aUpdateTowMotorMainHoursTableAdapter;

        FindActiveTowMotorMainDataSet aFindActiveTowMotorMainDataSet;
        FindActiveTowMotorMainDataSetTableAdapters.FindActiveTowMotorMainTableAdapter aFindActiveTowMotorMainTableAdapter;

        FindTowMotorMainByTowMotorNumberDataSet aFindTowMotorMainByTowMotorNumberDataSet;
        FindTowMotorMainByTowMotorNumberDataSetTableAdapters.FindTowMotorMainByTowMotorNumberTableAdapter aFindTowMotorMainbyTowMotorNumberTableAdapter;

        FindTowMotorMainByTowMotorIDDataSet aFindTowMotorMainByTowMotorIDDataSet;
        FindTowMotorMainByTowMotorIDDataSetTableAdapters.FindTowMotorMainByTowMotorIDTableAdapter aFindTowMotorMainByTowMotorIDTableAdapter;

        FindTowMotorMainByWarehouseIDDataSet aFindTowMotorMainByWarehouseIDDataSet;
        FindTowMotorMainByWarehouseIDDataSetTableAdapters.FindTowMotorMainByWarehouseIDTableAdapter aFindTowMotorMainByWarehouseIDTableAdapter;

        TowMotorInspectionDataSet aTowMotorInspectionDataSet;
        TowMotorInspectionDataSetTableAdapters.towmotorinspectionTableAdapter aTowMotorInspectionTableAdapter;

        InsertTowMotorInspectionEntryTableAdapters.QueriesTableAdapter aInsertTowMotorInspectionTableAdapter;

        FindTowMotorInspectionByDateMatchDataSet aFindTowMotorInspectionByDateMatchDataSet;
        FindTowMotorInspectionByDateMatchDataSetTableAdapters.FindTowMotorInspectionByDateMatchTableAdapter aFindTowMotorInspectionByDateMatchTableAdapter;

        FindTowMotorInspectionByDateRangeDataSet aFindTowMotorInspectionByDateRangeDataSet;
        FindTowMotorInspectionByDateRangeDataSetTableAdapters.FindTowMotorInspectionByDateRangeTableAdapter aFindTowMotorInspectionByDateRangeTableAdapter;

        FindTowMotorInspectionByTowMotorIDDataSet aFindTowMotorInspectionByTowMotorIDDataSet;
        FindTowMotorInspectionByTowMotorIDDataSetTableAdapters.FindTowMotorInspectionByTowmotorIDTableAdapter aFindTowMotorInspectionByTowMotorIDTableAdapter;

        FindTowMotorInspectionByEmployeeIDDataSet aFindTowMotorInspectionByEmployeeIDDataSet;
        FindTowMotorInspectionByEmployeeIDDataSetTableAdapters.FindTowMotorInspectionByEmployeeIDTableAdapter aFindTowMotorInspectionByEmployeeIDTableAdapter;

        TowMotorEngineOnDataSet aTowMotorEngineOnDataSet;
        TowMotorEngineOnDataSetTableAdapters.towmotorengineonTableAdapter aTowMotorEngineOnTableAdapter;

        InsertTowMotorEngineOnEntryTableAdapters.QueriesTableAdapter aInsertTowMotorEngineOnTableAdapter;

        FindTowMotorInspectionEngineOnDataSet aFindTowMotorInspectionEngineOnDataSet;
        FindTowMotorInspectionEngineOnDataSetTableAdapters.FindTowMotorInspectionEngineOnTableAdapter aFindTowMotorInspectionEngineOnTableAdapter;

        TowMotorEngineOffDataSet aTowMotorEngineOffDataSet;
        TowMotorEngineOffDataSetTableAdapters.towmotorengineoffTableAdapter aTowMotorEngineOffTableAdapter;

        InsertTowMotorEngineOffEntryTableAdapters.QueriesTableAdapter aInsertTowMotorEngineOffTableAdapter;

        FindTowMotorInspectionEngineOffByInspectionIDDataSet aFindTowMotorInspectionEngineOffByInspectionIDDataSet;
        FindTowMotorInspectionEngineOffByInspectionIDDataSetTableAdapters.FindTowMotorInspectionEngineOffByInspectionIDTableAdapter aFindTowMotorInspectionEngineOffByInspectionIDTableAdapter;

        TowMotorAssetsDataSet aTowMotorAssetsDataSet;
        TowMotorAssetsDataSetTableAdapters.towmotorassetsTableAdapter aTowMotorAssetsTableAdapter;

        InsertTowMotorAssetsEntryTableAdapters.QueriesTableAdapter aInsertTowMotorAssetTableAdapter;

        FindTowMotorAssetsByInspectionIDDataSet aFindTowMotorAssetsByInspectionIDDataSet;
        FindTowMotorAssetsByInspectionIDDataSetTableAdapters.FindTowMotorAssetsByInspectionIDTableAdapter aFindTowMotorAssetsByInspectionIDTableAdater;

        TowMotorInspectionDocumentationDataSet aTowMotorInspectionDocumentationDataSet;
        TowMotorInspectionDocumentationDataSetTableAdapters.towmotorinsepctiondocumentationTableAdapter aTowMotorInspectionDocumentationTableAdapter;

        InsertTowMotorInspectionDocumentationEntryTableAdapters.QueriesTableAdapter aInsertTowMotorInspectionDocumentationTableAdapter;

        FindTowMotorInspectionDocumentationByInspectionIDDataSet aFindTowMotorInspectionDocumentationByInspectionIDDataSet;
        FindTowMotorInspectionDocumentationByInspectionIDDataSetTableAdapters.FindTowMotorInspectionDocumentationByInspectionIDTableAdapter aFindTowMotorInspectionDocumentationByInspectionIDTableAdapter;

        TowMotorInspectionOverAllDataSet aTowMotorInspectionOverAllDataSet;
        TowMotorInspectionOverAllDataSetTableAdapters.towmotorinspectionoverallTableAdapter aTowMotorInspectionOverAllTableAdapter;

        InsertTowMotorInspectionOverAllEntryTableAdapters.QueriesTableAdapter aInsertTowMotorInspectionOverAllTableAdapter;

        FindTowMotorInspectionOverAllByInspectionIDDataSet aFindTowMotorInspectionOverAllbyInspectionIDDataSet;
        FindTowMotorInspectionOverAllByInspectionIDDataSetTableAdapters.FindTowMotorInspectionOverAllByInspectionIDTableAdapter aFindTowMotorInspectionOverAllByInspectionIDTableAdapter;

        FindTowMotorInspectionOverAllByInspectionResultsDataSet aFindTowMotorInspectionOverAllByInspectionResultsDataSet;
        FindTowMotorInspectionOverAllByInspectionResultsDataSetTableAdapters.FindTowMotorInspectionOverAllByInspectionResultsTableAdapter aFindTowMotorInspectionOverAllByInspectionResultsTableAdapter;

        FindTowMotorInspectionResultsOverDateRangeDataSet aFindTowMotorInspectionResultsOverDateRangeDataSet;
        FindTowMotorInspectionResultsOverDateRangeDataSetTableAdapters.FindTowMotorInspectionResultsOverDateRangeTableAdapter aFindTowMotorInspectionResultsOverDateRangeTableAdapter;

        InsertTowMotorInspectionProblemEntryTableAdapters.QueriesTableAdapter aInsertTowMotorInspectionProblemTableAdapter;

        FindTowMotorInspectionProblemByInspectionIDDataSet aFindTowMotorInspectionProblemByInspectionIDDataSet;
        FindTowMotorInspectionProblemByInspectionIDDataSetTableAdapters.FindTowMotorInspectionProblemByInspectionIDTableAdapter aFindTowMotorInspectionProblemByInspectionIDTableAdapter;

        FindTowMotorInspectionsWithProblemsDataSet aFindTowMotorInspectionsWithProblemsDataSet;
        FindTowMotorInspectionsWithProblemsDataSetTableAdapters.FindTowMotorInspectionsWithProblemsTableAdapter aFindTowMotorInspectionsWithProblemsTableAdapter;

        TowMotorProblemsDataSet aTowMotorProblemsDataSet;
        TowMotorProblemsDataSetTableAdapters.towmotorproblemsTableAdapter aTowMotorProblemsTableAdapter;

        InsertTowMotorProblemEntryTableAdapters.QueriesTableAdapter aInsertTowMotorProblemTableAdapter;

        UpdateTowMotorProblemWorkPerformedEntryTableAdapters.QueriesTableAdapter aUpdateTowMotorProblemWorkPerformedTableAdapter;

        UpdateTowMotorProblemStatusEntryTableAdapters.QueriesTableAdapter aUpdateTowMotorProblemStatusTableAdapter;

        UpdateTowMotorProblemInvoiceEntryTableAdapters.QueriesTableAdapter aUpdateTowMotorProblemInvoiceTableAdapter;

        FindTowMotorProblemsByProblemStatusDataSet aFindTowMotorProblemsByProblemStatusDataSet;
        FindTowMotorProblemsByProblemStatusDataSetTableAdapters.FindTowMotorProblemsByProblemStatusTableAdapter aFindTowMotorProblemsByProblemStatusTableAdapter;

        FindTowMotorProblemsByTowMotorIDDataSet aFindTowMotorProblemsByTowMotorIDDataSet;
        FindTowMotorProblemsByTowMotorIDDataSetTableAdapters.FindTowMotorProblemsByTowMotorIDTableAdapter aFindTowMotorProblemsByTowMotorIDTableAdapter;

        FindTowMotorProblemsByDateRangeDataSet aFindTowMotorProblemsByDateRangeDataSet;
        FindTowMotorProblemsByDateRangeDataSetTableAdapters.FindTowMotorInspectionByDateRangeTableAdapter aFindTowMotorProblemsByDateRangeTableAdapter;

        TowMotorProblemUpdatesDataSet aTowMotorProblemUpdatesDataSet;
        TowMotorProblemUpdatesDataSetTableAdapters.towmotorproblemupdatesTableAdapter aTowMotorProblemUpdatesTableAdapter;

        InsertTowMotorProblemUpdateEntryTableAdapters.QueriesTableAdapter aInsertTowMotorProblemUpdateTableAdapter;

        FindTowMotorProblemUpdatesByProblemIDDataSet aFindTowMotorProblemUpdatesByProblemIDDataSet;
        FindTowMotorProblemUpdatesByProblemIDDataSetTableAdapters.FindTowMotorProblemUpdateByProblemIDTableAdapter aFindTowMotorProblemUpdatesByProblemIDTableAdapter;

        TowMotorProblemDocumentationDataSet aTowMotorProblemDocumentationDataSet;
        TowMotorProblemDocumentationDataSetTableAdapters.towmotorproblemdocumentationTableAdapter aTowMotorProblemDocumentationTableAdapter;

        InsertTowMotorProblemDocumentationEntryTableAdapters.QueriesTableAdapter aInsertTowMotorProblemDocumentationTableAdapter;

        FindTowMotorProblemDocumentationByProblemIDDataSet aFindTowMotorProblemDocumentationByProblemIDDataSet;
        FindTowMotorProblemDocumentationByProblemIDDataSetTableAdapters.FindTowMotorProblemDocumentationByProblemIDTableAdapter aFindTowMotorProblemDocumentationByProblemIDTableAdapter;

        public FindTowMotorInspectionResultsOverDateRangeDataSet FindTowMotorInspectionResultsOverDateRange(DateTime datStartDate, DateTime datEndDate)
        {
            try
            {
                aFindTowMotorInspectionResultsOverDateRangeDataSet = new FindTowMotorInspectionResultsOverDateRangeDataSet();
                aFindTowMotorInspectionResultsOverDateRangeTableAdapter = new FindTowMotorInspectionResultsOverDateRangeDataSetTableAdapters.FindTowMotorInspectionResultsOverDateRangeTableAdapter();
                aFindTowMotorInspectionResultsOverDateRangeTableAdapter.Fill(aFindTowMotorInspectionResultsOverDateRangeDataSet.FindTowMotorInspectionResultsOverDateRange, datStartDate, datEndDate);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Tow Motor Class // Find Tow Motor Inspection Results Over Date Range " + Ex.Message);
            }

            return aFindTowMotorInspectionResultsOverDateRangeDataSet;
        }
        public FindTowMotorInspectionByEmployeeIDDataSet FindTowMotorInspectioinByEmployeeID(int intEmployeeID, DateTime datStartDate, DateTime datEndDate)
        {
            try
            {
                aFindTowMotorInspectionByEmployeeIDDataSet = new FindTowMotorInspectionByEmployeeIDDataSet();
                aFindTowMotorInspectionByEmployeeIDTableAdapter = new FindTowMotorInspectionByEmployeeIDDataSetTableAdapters.FindTowMotorInspectionByEmployeeIDTableAdapter();
                aFindTowMotorInspectionByEmployeeIDTableAdapter.Fill(aFindTowMotorInspectionByEmployeeIDDataSet.FindTowMotorInspectionByEmployeeID, intEmployeeID, datStartDate, datEndDate);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Tow Motor Class // Find Tow Motor Inspection By Employee ID " + Ex.Message);
            }

            return aFindTowMotorInspectionByEmployeeIDDataSet;
        }
        public FindTowMotorMainByTowMotorNumberDataSet FindTowMotorMainByTowMotorNumber(string strTowMotorNumber)
        {
            try
            {
                aFindTowMotorMainByTowMotorNumberDataSet = new FindTowMotorMainByTowMotorNumberDataSet();
                aFindTowMotorMainbyTowMotorNumberTableAdapter = new FindTowMotorMainByTowMotorNumberDataSetTableAdapters.FindTowMotorMainByTowMotorNumberTableAdapter();
                aFindTowMotorMainbyTowMotorNumberTableAdapter.Fill(aFindTowMotorMainByTowMotorNumberDataSet.FindTowMotorMainByTowMotorNumber, strTowMotorNumber);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Tow Motor Class // Find Tow Motor Main By Tow Motor Number " + Ex.Message);
            }

            return aFindTowMotorMainByTowMotorNumberDataSet;
        }
        public FindTowMotorProblemDocumentationByProblemIDDataSet FindTowMotorProblemDocumentationByProblemID(int intProblemID)
        {
            try
            {
                aFindTowMotorProblemDocumentationByProblemIDDataSet = new FindTowMotorProblemDocumentationByProblemIDDataSet();
                aFindTowMotorProblemDocumentationByProblemIDTableAdapter = new FindTowMotorProblemDocumentationByProblemIDDataSetTableAdapters.FindTowMotorProblemDocumentationByProblemIDTableAdapter();
                aFindTowMotorProblemDocumentationByProblemIDTableAdapter.Fill(aFindTowMotorProblemDocumentationByProblemIDDataSet.FindTowMotorProblemDocumentationByProblemID, intProblemID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Tow Motor Class // Find Tow Motor Problem Documentation By Problem ID " + Ex.Message);
            }

            return aFindTowMotorProblemDocumentationByProblemIDDataSet;
        }
        public bool InsertTowMotorProblemDocumentation(int intProblemID, int intEmployeeID, string strDocumentType, string strDocumentPath)
        {
            bool blnFatalError = false;

            try
            {
                aInsertTowMotorProblemDocumentationTableAdapter = new InsertTowMotorProblemDocumentationEntryTableAdapters.QueriesTableAdapter();
                aInsertTowMotorProblemDocumentationTableAdapter.InsertTowMotorProblemDocumentation(intProblemID, intEmployeeID, DateTime.Now, strDocumentType, strDocumentPath);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Tow Motor Class // Insert Tow Motor Problem Documentation " + Ex.Message);
            }

            return blnFatalError;
        }
        public TowMotorProblemDocumentationDataSet GetTowMotorProblemDocumentationInfo()
        {
            try
            {
                aTowMotorProblemDocumentationDataSet = new TowMotorProblemDocumentationDataSet();
                aTowMotorProblemDocumentationTableAdapter = new TowMotorProblemDocumentationDataSetTableAdapters.towmotorproblemdocumentationTableAdapter();
                aTowMotorProblemDocumentationTableAdapter.Fill(aTowMotorProblemDocumentationDataSet.towmotorproblemdocumentation);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Tow Motor Class // Get Tow Motor Problem Documentation " + Ex.Message);
            }

            return aTowMotorProblemDocumentationDataSet;
        }
        public void UpdateTowMotorProblemDocumentationDB(TowMotorProblemDocumentationDataSet aTowMotorProblemDocumentationDataSet)
        {
            try
            {
                aTowMotorProblemDocumentationTableAdapter = new TowMotorProblemDocumentationDataSetTableAdapters.towmotorproblemdocumentationTableAdapter();
                aTowMotorProblemDocumentationTableAdapter.Update(aTowMotorProblemDocumentationDataSet.towmotorproblemdocumentation);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Tow Motor Class // Update Tow Motor Problem DB " + Ex.Message);
            }
        }
        public FindTowMotorProblemUpdatesByProblemIDDataSet FindTowMotorProblemUpdatesByProblemID(int intProblemID)
        {
            try
            {
                aFindTowMotorProblemUpdatesByProblemIDDataSet = new FindTowMotorProblemUpdatesByProblemIDDataSet();
                aFindTowMotorProblemUpdatesByProblemIDTableAdapter = new FindTowMotorProblemUpdatesByProblemIDDataSetTableAdapters.FindTowMotorProblemUpdateByProblemIDTableAdapter();
                aFindTowMotorProblemUpdatesByProblemIDTableAdapter.Fill(aFindTowMotorProblemUpdatesByProblemIDDataSet.FindTowMotorProblemUpdateByProblemID, intProblemID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Tow Motor Class // Find Tow Motor Problem Updates By Problem ID " + Ex.Message);
            }

            return aFindTowMotorProblemUpdatesByProblemIDDataSet;
        }
        public bool InsertTowMotorProblemUpdate(int intProblemID, int intEmployeeID, string strProblemUpdate)
        {
            bool blnFatalError = false;

            try
            {
                aInsertTowMotorProblemUpdateTableAdapter = new InsertTowMotorProblemUpdateEntryTableAdapters.QueriesTableAdapter();
                aInsertTowMotorProblemUpdateTableAdapter.InsertTowMotorProblemUpdate(intProblemID, intEmployeeID, DateTime.Now, strProblemUpdate);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Tow Motor Class // Insert Tow Motor Problem Update " + Ex.Message);
            }

            return blnFatalError;
        }
        public TowMotorProblemUpdatesDataSet GetTowMotorProblemUpdatesInfo()
        {
            try
            {
                aTowMotorProblemUpdatesDataSet = new TowMotorProblemUpdatesDataSet();
                aTowMotorProblemUpdatesTableAdapter = new TowMotorProblemUpdatesDataSetTableAdapters.towmotorproblemupdatesTableAdapter();
                aTowMotorProblemUpdatesTableAdapter.Fill(aTowMotorProblemUpdatesDataSet.towmotorproblemupdates);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Tow Motor Class // Get Tow Motor Problem Updates Info " + Ex.Message);
            }

            return aTowMotorProblemUpdatesDataSet;
        }
        public void UpdateTowMotorProblemUpdatesDB(TowMotorProblemUpdatesDataSet aTowMotorProblemUpdatesDataSet)
        {
            try
            {
                aTowMotorProblemUpdatesTableAdapter = new TowMotorProblemUpdatesDataSetTableAdapters.towmotorproblemupdatesTableAdapter();
                aTowMotorProblemUpdatesTableAdapter.Update(aTowMotorProblemUpdatesDataSet.towmotorproblemupdates);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Tow Motor Class // Update Tow Motor Problem Updates DB " + Ex.Message);
            }
        }
        public FindTowMotorProblemsByDateRangeDataSet FindTowMotorProblemsByDateRange(DateTime datStartDate, DateTime datEndDate)
        {
            try
            {
                aFindTowMotorProblemsByDateRangeDataSet = new FindTowMotorProblemsByDateRangeDataSet();
                aFindTowMotorProblemsByDateRangeTableAdapter = new FindTowMotorProblemsByDateRangeDataSetTableAdapters.FindTowMotorInspectionByDateRangeTableAdapter();
                aFindTowMotorProblemsByDateRangeTableAdapter.Fill(aFindTowMotorProblemsByDateRangeDataSet.FindTowMotorInspectionByDateRange, datStartDate, datEndDate);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Tow Motor Class // Find Tow Motor Problems By Date Range " + Ex.Message);
            }

            return aFindTowMotorProblemsByDateRangeDataSet;
        }
        public FindTowMotorProblemsByTowMotorIDDataSet FindTowMotorProblemsByTowMotorID(int intTowMotorID)
        {
            try
            {
                aFindTowMotorProblemsByTowMotorIDDataSet = new FindTowMotorProblemsByTowMotorIDDataSet();
                aFindTowMotorProblemsByTowMotorIDTableAdapter = new FindTowMotorProblemsByTowMotorIDDataSetTableAdapters.FindTowMotorProblemsByTowMotorIDTableAdapter();
                aFindTowMotorProblemsByTowMotorIDTableAdapter.Fill(aFindTowMotorProblemsByTowMotorIDDataSet.FindTowMotorProblemsByTowMotorID, intTowMotorID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Tow Motor Class // Find Tow Motor Problems By Tow Motor ID " + Ex.Message);
            }

            return aFindTowMotorProblemsByTowMotorIDDataSet;
        }
        public FindTowMotorProblemsByProblemStatusDataSet FindTowMotorProblemsByProblemStatus(int intProblemStatusID)
        {
            try
            {
                aFindTowMotorProblemsByProblemStatusDataSet = new FindTowMotorProblemsByProblemStatusDataSet();
                aFindTowMotorProblemsByProblemStatusTableAdapter = new FindTowMotorProblemsByProblemStatusDataSetTableAdapters.FindTowMotorProblemsByProblemStatusTableAdapter();
                aFindTowMotorProblemsByProblemStatusTableAdapter.Fill(aFindTowMotorProblemsByProblemStatusDataSet.FindTowMotorProblemsByProblemStatus, intProblemStatusID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Tow Motor Class // Find Tow Motor Problems By Problem Status " + Ex.Message);
            }

            return aFindTowMotorProblemsByProblemStatusDataSet;
        }
        public bool UpdateTowMotorProblemInvoice(int intProblemID, DateTime datInvoiceDate, decimal decInvoiceAmount)
        {
            bool blnFatalError = false;

            try
            {
                aUpdateTowMotorProblemInvoiceTableAdapter = new UpdateTowMotorProblemInvoiceEntryTableAdapters.QueriesTableAdapter();
                aUpdateTowMotorProblemInvoiceTableAdapter.UpdateTowMotorProblemInvoice(intProblemID, datInvoiceDate, decInvoiceAmount);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Tow Motor Class // Update Tow Motor Problem Invoice " + Ex.Message);

                blnFatalError = true;
            }

            return blnFatalError;
        }
        public bool UpdateTowMotorProblemStatus(int intProblemID, int intProblemStatus)
        {
            bool blnFatalError = false;

            try
            {
                aUpdateTowMotorProblemStatusTableAdapter = new UpdateTowMotorProblemStatusEntryTableAdapters.QueriesTableAdapter();
                aUpdateTowMotorProblemStatusTableAdapter.UpdateTowMotorProblemStatus(intProblemID, intProblemStatus);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Tow Motor Class // Update Tow Motor Problem Status " + Ex.Message);

                blnFatalError = true;
            }

            return blnFatalError;
        }
        public bool UpdateTowMotorProblemWorkPerformed(int intProblemID, DateTime datDateWorkPerformed, string strWorkPerformed)
        {
            bool blnFatalError = false;

            try
            {
                aUpdateTowMotorProblemWorkPerformedTableAdapter = new UpdateTowMotorProblemWorkPerformedEntryTableAdapters.QueriesTableAdapter();
                aUpdateTowMotorProblemWorkPerformedTableAdapter.UpdateTowMotorWorkPerformed(intProblemID, datDateWorkPerformed, strWorkPerformed);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Tow Motor Class // Update Tow Motor Problem Worked Performed " + Ex.Message);

                blnFatalError = true;
            }

            return blnFatalError;
        }
        public bool InsertTowMotorProblem(int intTowMotorID, int intEmployeeID, DateTime datEnteredDate, DateTime datReportedDate, string strProblemReported, int intProblemStatus)
        {
            bool blnFatalError = false;

            try
            {
                aInsertTowMotorProblemTableAdapter = new InsertTowMotorProblemEntryTableAdapters.QueriesTableAdapter();
                aInsertTowMotorProblemTableAdapter.InsertTowMotorProblem(intTowMotorID, intEmployeeID, datEnteredDate, datReportedDate, strProblemReported, intProblemStatus);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Tow Motor Class // Insert Tow Motor Problem " + Ex.Message);

                blnFatalError = true;
            }

            return blnFatalError;
        }
        public TowMotorProblemsDataSet GetTowMotorProblemsInfo()
        {
            try
            {
                aTowMotorProblemsDataSet = new TowMotorProblemsDataSet();
                aTowMotorProblemsTableAdapter = new TowMotorProblemsDataSetTableAdapters.towmotorproblemsTableAdapter();
                aTowMotorProblemsTableAdapter.Fill(aTowMotorProblemsDataSet.towmotorproblems);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Tow Motor Class // Get Tow Motor Problems Info " + Ex.Message);
            }

            return aTowMotorProblemsDataSet;
        }
        public void UpdateTowMotorProblemsDB(TowMotorProblemsDataSet aTowMotorProblemsDataSet)
        {
            try
            { 
                aTowMotorProblemsTableAdapter = new TowMotorProblemsDataSetTableAdapters.towmotorproblemsTableAdapter();
                aTowMotorProblemsTableAdapter.Update(aTowMotorProblemsDataSet.towmotorproblems);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Tow Motor Class // Update Tow Motor Problems DB " + Ex.Message);
            }
        }
        public FindTowMotorInspectionsWithProblemsDataSet FindTowMotorInspectionsWithProblems(DateTime datStartDate, DateTime datEndDate)
        {
            try
            {
                aFindTowMotorInspectionsWithProblemsDataSet = new FindTowMotorInspectionsWithProblemsDataSet();
                aFindTowMotorInspectionsWithProblemsTableAdapter = new FindTowMotorInspectionsWithProblemsDataSetTableAdapters.FindTowMotorInspectionsWithProblemsTableAdapter();
                aFindTowMotorInspectionsWithProblemsTableAdapter.Fill(aFindTowMotorInspectionsWithProblemsDataSet.FindTowMotorInspectionsWithProblems, datStartDate, datEndDate);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Tow Motor Class // Find Tow Motor Inspection With Problems " + Ex.Message);
            }

            return aFindTowMotorInspectionsWithProblemsDataSet;
        }
        public FindTowMotorInspectionProblemByInspectionIDDataSet FindTowMotorInspectionProblemByInspectionID(int intInspectionID)
        {
            try
            {
                aFindTowMotorInspectionProblemByInspectionIDDataSet = new FindTowMotorInspectionProblemByInspectionIDDataSet();
                aFindTowMotorInspectionProblemByInspectionIDTableAdapter = new FindTowMotorInspectionProblemByInspectionIDDataSetTableAdapters.FindTowMotorInspectionProblemByInspectionIDTableAdapter();
                aFindTowMotorInspectionProblemByInspectionIDTableAdapter.Fill(aFindTowMotorInspectionProblemByInspectionIDDataSet.FindTowMotorInspectionProblemByInspectionID, intInspectionID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Tow Motor Class // Find Tow Motor Inspection Problem By Inspection ID " + Ex.Message);
            }

            return aFindTowMotorInspectionProblemByInspectionIDDataSet;
        }
        public bool InsertTowMotorInspectionProblem(int intInspectionID, int intEmployeeID, string strTowMotorProblem, string strTowMotorProblemUpdate)
        {
            bool blnFatalError = false;

            try
            {
                aInsertTowMotorInspectionProblemTableAdapter = new InsertTowMotorInspectionProblemEntryTableAdapters.QueriesTableAdapter();
                aInsertTowMotorInspectionProblemTableAdapter.InsertTowMotorInspectionProblem(intInspectionID, intEmployeeID, strTowMotorProblem, strTowMotorProblemUpdate);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Tow Motor Class // Insert Tow Motor Inspection Problem " + Ex.Message);

                blnFatalError = true;
            }

            return blnFatalError;
        }
        public FindTowMotorInspectionOverAllByInspectionResultsDataSet FindTowMotorInspectionOverAllByInspectionResults(string strInspectionResults, DateTime datStartDate, DateTime datEndDate)
        {
            try
            {
                aFindTowMotorInspectionOverAllByInspectionResultsDataSet = new FindTowMotorInspectionOverAllByInspectionResultsDataSet();
                aFindTowMotorInspectionOverAllByInspectionResultsTableAdapter = new FindTowMotorInspectionOverAllByInspectionResultsDataSetTableAdapters.FindTowMotorInspectionOverAllByInspectionResultsTableAdapter();
                aFindTowMotorInspectionOverAllByInspectionResultsTableAdapter.Fill(aFindTowMotorInspectionOverAllByInspectionResultsDataSet.FindTowMotorInspectionOverAllByInspectionResults, strInspectionResults, datStartDate, datEndDate);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Tow Motor Class // Find Tow Motor Inspection Over All By Inspection Results " + Ex.Message);
            }

            return aFindTowMotorInspectionOverAllByInspectionResultsDataSet;
        }
        public FindTowMotorInspectionOverAllByInspectionIDDataSet FindTowMotorInspectionOverAllByInspectionID(int intInspectionID)
        {
            try
            {
                aFindTowMotorInspectionOverAllbyInspectionIDDataSet = new FindTowMotorInspectionOverAllByInspectionIDDataSet();
                aFindTowMotorInspectionOverAllByInspectionIDTableAdapter = new FindTowMotorInspectionOverAllByInspectionIDDataSetTableAdapters.FindTowMotorInspectionOverAllByInspectionIDTableAdapter();
                aFindTowMotorInspectionOverAllByInspectionIDTableAdapter.Fill(aFindTowMotorInspectionOverAllbyInspectionIDDataSet.FindTowMotorInspectionOverAllByInspectionID, intInspectionID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Tow Motor Class // Find Tow Motor Inspection Over All By Inspection ID " + Ex.Message);
            }

            return aFindTowMotorInspectionOverAllbyInspectionIDDataSet;
        }
        public bool InsertTowMotorInspectionOverAll(int intInspectionID, string strInspectionResults, string strInspectionComments, int intManagerID)
        {
            bool blnFatalError = false;

            try
            {
                aInsertTowMotorInspectionOverAllTableAdapter = new InsertTowMotorInspectionOverAllEntryTableAdapters.QueriesTableAdapter();
                aInsertTowMotorInspectionOverAllTableAdapter.InsertTowMotorInspectionOverAll(intInspectionID, DateTime.Now, strInspectionResults, strInspectionComments, intManagerID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Tow Motor Class // Insert Tow Motor Inspection Over All " + Ex.Message);

                blnFatalError = true;
            }

            return blnFatalError;
        }
        public TowMotorInspectionOverAllDataSet GetTowMotorInspectionOverAllInfo()
        {
            try
            {
                aTowMotorInspectionOverAllDataSet = new TowMotorInspectionOverAllDataSet();
                aTowMotorInspectionOverAllTableAdapter = new TowMotorInspectionOverAllDataSetTableAdapters.towmotorinspectionoverallTableAdapter();
                aTowMotorInspectionOverAllTableAdapter.Fill(aTowMotorInspectionOverAllDataSet.towmotorinspectionoverall);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Tow Motor Class // Get Tow Motor Inspection Over All Info " + Ex.Message);
            }

            return aTowMotorInspectionOverAllDataSet;
        }
        public void UpdateTowMotorInspectionOverAllDB(TowMotorInspectionOverAllDataSet aTowMotorInspectionOverAllDataSet)
        {
            try
            {
                aTowMotorInspectionOverAllTableAdapter = new TowMotorInspectionOverAllDataSetTableAdapters.towmotorinspectionoverallTableAdapter();
                aTowMotorInspectionOverAllTableAdapter.Update(aTowMotorInspectionOverAllDataSet.towmotorinspectionoverall);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Tow Motor Class // Get Tow Motor Inspection Over All Info " + Ex.Message);
            }
        }
        public FindTowMotorInspectionDocumentationByInspectionIDDataSet FindTowMotorInspectionByInspectionID(int intInspectionID)
        {
            try
            {
                aFindTowMotorInspectionDocumentationByInspectionIDDataSet = new FindTowMotorInspectionDocumentationByInspectionIDDataSet();
                aFindTowMotorInspectionDocumentationByInspectionIDTableAdapter = new FindTowMotorInspectionDocumentationByInspectionIDDataSetTableAdapters.FindTowMotorInspectionDocumentationByInspectionIDTableAdapter();
                aFindTowMotorInspectionDocumentationByInspectionIDTableAdapter.Fill(aFindTowMotorInspectionDocumentationByInspectionIDDataSet.FindTowMotorInspectionDocumentationByInspectionID, intInspectionID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Tow Motor Class // Find Tow Motor Inspection By Inspection ID " + Ex.Message);
            }

            return aFindTowMotorInspectionDocumentationByInspectionIDDataSet;
        }
        public bool InsertTowMotorInspectionDocumentation(int intInspectionID, int intEmployeeID, string strDocumentPath)
        {
            bool blnFatalError = false;

            try
            {
                aInsertTowMotorInspectionDocumentationTableAdapter = new InsertTowMotorInspectionDocumentationEntryTableAdapters.QueriesTableAdapter();
                aInsertTowMotorInspectionDocumentationTableAdapter.InsertTowMotorInspectionDocumentation(intInspectionID, intEmployeeID, DateTime.Now, strDocumentPath);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Tow Motor Class // Insert Tow Motor Inspection Documentation " + Ex.Message);

                blnFatalError = true;
            }

            return blnFatalError;
        }
        public TowMotorInspectionDocumentationDataSet GetTowMotorInspectionDocumentationInfo()
        {
            try
            {
                aTowMotorInspectionDocumentationDataSet = new TowMotorInspectionDocumentationDataSet();
                aTowMotorInspectionDocumentationTableAdapter = new TowMotorInspectionDocumentationDataSetTableAdapters.towmotorinsepctiondocumentationTableAdapter();
                aTowMotorInspectionDocumentationTableAdapter.Fill(aTowMotorInspectionDocumentationDataSet.towmotorinsepctiondocumentation);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Tow Motor Class // Get Tow Motor Inspection Documentation Info " + Ex.Message);
            }

            return aTowMotorInspectionDocumentationDataSet;
        }
        public void UpdateTowMotorInspectionDocumentationDB(TowMotorInspectionDocumentationDataSet aTowMotorInspectionDocumentationDataSet)
        {
            try
            {
                aTowMotorInspectionDocumentationTableAdapter = new TowMotorInspectionDocumentationDataSetTableAdapters.towmotorinsepctiondocumentationTableAdapter();
                aTowMotorInspectionDocumentationTableAdapter.Update(aTowMotorInspectionDocumentationDataSet.towmotorinsepctiondocumentation);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Tow Motor Class // Update Tow Motor Inspection Documentation DB " + Ex.Message);
            }
        }
        public FindTowMotorAssetsByInspectionIDDataSet FindTowMotorAssetsByInspectionID(int intInspectionID)
        {
            try
            {
                aFindTowMotorAssetsByInspectionIDDataSet = new FindTowMotorAssetsByInspectionIDDataSet();
                aFindTowMotorAssetsByInspectionIDTableAdater = new FindTowMotorAssetsByInspectionIDDataSetTableAdapters.FindTowMotorAssetsByInspectionIDTableAdapter();
                aFindTowMotorAssetsByInspectionIDTableAdater.Fill(aFindTowMotorAssetsByInspectionIDDataSet.FindTowMotorAssetsByInspectionID, intInspectionID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Tow Motor Class // Find Tow Motor Assets By Inspection ID " + Ex.Message);
            }

            return aFindTowMotorAssetsByInspectionIDDataSet;
        }
        public bool InsertTowMotorAssets(int intInspectionID, int intSafetyCones, int intSafetyGlasses, int intHardHat, int intFireExtinguisher)
        {
            bool blnFatalError = false;

            try
            {
                aInsertTowMotorAssetTableAdapter = new InsertTowMotorAssetsEntryTableAdapters.QueriesTableAdapter();
                aInsertTowMotorAssetTableAdapter.InsertTowMotorAssets(intInspectionID, intSafetyCones, intSafetyGlasses, intHardHat, intFireExtinguisher);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Tow Motor Class // Insert Tow Motor Assets " + Ex.Message);

                blnFatalError = true;
            }

            return blnFatalError;
        }
        public TowMotorAssetsDataSet GetTowMotorAssetsInfo()
        {
            try
            {
                aTowMotorAssetsDataSet = new TowMotorAssetsDataSet();
                aTowMotorAssetsTableAdapter = new TowMotorAssetsDataSetTableAdapters.towmotorassetsTableAdapter();
                aTowMotorAssetsTableAdapter.Fill(aTowMotorAssetsDataSet.towmotorassets);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Tow Motor Class // Get Tow Motor Assets Info " + Ex.Message);
            }

            return aTowMotorAssetsDataSet;
        }
        public void UpdateTowMotorAssetsDB(TowMotorAssetsDataSet aTowMotorAssetsDataSet)
        {
            try
            {
                aTowMotorAssetsTableAdapter = new TowMotorAssetsDataSetTableAdapters.towmotorassetsTableAdapter();
                aTowMotorAssetsTableAdapter.Update(aTowMotorAssetsDataSet.towmotorassets);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Tow Motor Class // Update Tow Motor Assets DB " + Ex.Message);
            }
        }
        public TowMotorEngineOffDataSet GetTowMotorEngineerOffInfo()
        {
            try
            {
                aTowMotorEngineOffDataSet = new TowMotorEngineOffDataSet();
                aTowMotorEngineOffTableAdapter = new TowMotorEngineOffDataSetTableAdapters.towmotorengineoffTableAdapter();
                aTowMotorEngineOffTableAdapter.Fill(aTowMotorEngineOffDataSet.towmotorengineoff);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Tow Motor Class // Get Tow Motor Engine Off Info " + Ex.Message);
            }

            return aTowMotorEngineOffDataSet;
        }
        public void UpdateTowMotorEngineOffDB(TowMotorEngineOffDataSet aTowMotorEngineOffDataSet)
        {
            try
            {
                aTowMotorEngineOffTableAdapter = new TowMotorEngineOffDataSetTableAdapters.towmotorengineoffTableAdapter();
                aTowMotorEngineOffTableAdapter.Update(aTowMotorEngineOffDataSet.towmotorengineoff);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Tow Motor Class // Update Tow Motor Engine Off DB " + Ex.Message);
            }
        }
        public FindTowMotorInspectionEngineOffByInspectionIDDataSet FindTowMotorInspectionEngineOffByInspectionID(int intInspectionID)
        {
            try
            {
                aFindTowMotorInspectionEngineOffByInspectionIDDataSet = new FindTowMotorInspectionEngineOffByInspectionIDDataSet();
                aFindTowMotorInspectionEngineOffByInspectionIDTableAdapter = new FindTowMotorInspectionEngineOffByInspectionIDDataSetTableAdapters.FindTowMotorInspectionEngineOffByInspectionIDTableAdapter();
                aFindTowMotorInspectionEngineOffByInspectionIDTableAdapter.Fill(aFindTowMotorInspectionEngineOffByInspectionIDDataSet.FindTowMotorInspectionEngineOffByInspectionID, intInspectionID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Tow Motor Class // Find Tow Motor Inspection Engine Off By Inspection ID " + Ex.Message);
            }

            return aFindTowMotorInspectionEngineOffByInspectionIDDataSet;
        }
        public bool InsertTowMotorEngineOff(int intInspectionID, bool blnTransmissionFluidLevel, bool blnEngineAirCleaner, bool blnFuelSedimentor, bool blnRadiatorCoolant, bool blnOperatorsManual, bool blnInformationPlate, bool blnSeatBelt, bool blnHoodLatch, bool blnBrakeFluid, bool blnOverheadGuard, bool blnFingerGuards, bool blnParkingBrake, bool blnSteeringOperation, bool blnDriveControl, bool blnTiltControl, bool blnCab, bool blnFuelLevel, bool blnTemperature, bool blnInstrumentMonitors)
        {
            bool blnFatalError = false;

            try
            {
                aInsertTowMotorEngineOffTableAdapter = new InsertTowMotorEngineOffEntryTableAdapters.QueriesTableAdapter();
                aInsertTowMotorEngineOffTableAdapter.InsertTowMotorEngineOff(intInspectionID, blnTransmissionFluidLevel, blnEngineAirCleaner, blnFuelSedimentor, blnRadiatorCoolant, blnOperatorsManual, blnInformationPlate, blnSeatBelt, blnHoodLatch, blnBrakeFluid, blnOverheadGuard, blnFingerGuards, blnParkingBrake, blnSteeringOperation, blnDriveControl, blnTiltControl, blnCab, blnFuelLevel, blnTemperature, blnInstrumentMonitors);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Tow Motor Class // Insert Tow Motor Engine Off " + Ex.Message);

                blnFatalError = true;
            }

            return blnFatalError;
        }
        public FindTowMotorInspectionEngineOnDataSet FindTowMotorInspectionEngineOn(int intInspectionID)
        {
            try
            {
                aFindTowMotorInspectionEngineOnDataSet = new FindTowMotorInspectionEngineOnDataSet();
                aFindTowMotorInspectionEngineOnTableAdapter = new FindTowMotorInspectionEngineOnDataSetTableAdapters.FindTowMotorInspectionEngineOnTableAdapter();
                aFindTowMotorInspectionEngineOnTableAdapter.Fill(aFindTowMotorInspectionEngineOnDataSet.FindTowMotorInspectionEngineOn, intInspectionID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Tow Motor Class // Find Tow Motor Inspection Engine On " + Ex.Message);
            }

            return aFindTowMotorInspectionEngineOnDataSet;
        }
        public bool InsertTowMotorEngineOn(int intInspectionID, bool blnLeaks, bool blnTires, bool blnForks, bool blnLoadBackrest, bool blnPropaneTank, bool blnSafetyWarning, bool blnBattery, bool blnEngineBelts, bool blnHydraulicFluid, bool blnEngineOilLevel,bool blnAccelorator, bool blnServiceBrake, bool blnHoistLoweringControl, bool blnAttachmentControl, bool blnHornLights, bool blnAmmeter, bool blnEngineOilPressure, bool blnHourMeter)
        {
            bool blnFatalError = false;

            try
            {
                aInsertTowMotorEngineOnTableAdapter = new InsertTowMotorEngineOnEntryTableAdapters.QueriesTableAdapter();
                aInsertTowMotorEngineOnTableAdapter.InsertTowMotorEngineOn(intInspectionID, blnLeaks, blnTires, blnForks, blnLoadBackrest, blnPropaneTank, blnSafetyWarning, blnBattery, blnEngineBelts, blnHydraulicFluid, blnEngineOilLevel, blnAccelorator, blnServiceBrake, blnHoistLoweringControl, blnAttachmentControl, blnHornLights, blnAmmeter, blnEngineOilPressure, blnHourMeter);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Tow Motor Class // Insert Tow Motor Engine On " + Ex.Message);

                blnFatalError = true;
            }

            return blnFatalError;
        }
        public TowMotorEngineOnDataSet GetTowMotorEngineOnInfo()
        {
            try
            {
                aTowMotorEngineOnDataSet = new TowMotorEngineOnDataSet();
                aTowMotorEngineOnTableAdapter = new TowMotorEngineOnDataSetTableAdapters.towmotorengineonTableAdapter();
                aTowMotorEngineOnTableAdapter.Fill(aTowMotorEngineOnDataSet.towmotorengineon);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Tow Motor Class // Get Tow Motor Engine On Info " + Ex.Message);
            }

            return aTowMotorEngineOnDataSet;
        }
        public void UpdateTowMotorEngineOnDB(TowMotorEngineOnDataSet aTowMotorEngineOnDataSet)
        {
            try
            {
                aTowMotorEngineOnTableAdapter = new TowMotorEngineOnDataSetTableAdapters.towmotorengineonTableAdapter();
                aTowMotorEngineOnTableAdapter.Update(aTowMotorEngineOnDataSet.towmotorengineon);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Tow Motor Class // Update Tow Motor Engine On DB " + Ex.Message);
            }
        }
        public FindTowMotorInspectionByTowMotorIDDataSet FindTowMotorInspectionByTowMotorID(int intTowMotorID, DateTime datStartDate, DateTime datEndDate)
        {
            try
            {
                aFindTowMotorInspectionByTowMotorIDDataSet = new FindTowMotorInspectionByTowMotorIDDataSet();
                aFindTowMotorInspectionByTowMotorIDTableAdapter = new FindTowMotorInspectionByTowMotorIDDataSetTableAdapters.FindTowMotorInspectionByTowmotorIDTableAdapter();
                aFindTowMotorInspectionByTowMotorIDTableAdapter.Fill(aFindTowMotorInspectionByTowMotorIDDataSet.FindTowMotorInspectionByTowmotorID, intTowMotorID, datStartDate, datEndDate);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Tow Motor Class // Find Tow Motor Inspection By Tow Motor ID " + Ex.Message);
            }

            return aFindTowMotorInspectionByTowMotorIDDataSet;
        }
        public FindTowMotorInspectionByDateRangeDataSet FindTowMotorInspectionByDateRange(DateTime datStartDate, DateTime datEndDate)
        {
            try
            {
                aFindTowMotorInspectionByDateRangeDataSet = new FindTowMotorInspectionByDateRangeDataSet();
                aFindTowMotorInspectionByDateRangeTableAdapter = new FindTowMotorInspectionByDateRangeDataSetTableAdapters.FindTowMotorInspectionByDateRangeTableAdapter();
                aFindTowMotorInspectionByDateRangeTableAdapter.Fill(aFindTowMotorInspectionByDateRangeDataSet.FindTowMotorInspectionByDateRange, datStartDate, datEndDate);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Tow Motor Class // Find Tow Motor Inspection By Date Range " + Ex.Message);
            }

            return aFindTowMotorInspectionByDateRangeDataSet;
        }
        public FindTowMotorInspectionByDateMatchDataSet FindTowMotorInspectionByDateMatch(DateTime datInspectionDate)
        {
            try
            {
                aFindTowMotorInspectionByDateMatchDataSet = new FindTowMotorInspectionByDateMatchDataSet();
                aFindTowMotorInspectionByDateMatchTableAdapter = new FindTowMotorInspectionByDateMatchDataSetTableAdapters.FindTowMotorInspectionByDateMatchTableAdapter();
                aFindTowMotorInspectionByDateMatchTableAdapter.Fill(aFindTowMotorInspectionByDateMatchDataSet.FindTowMotorInspectionByDateMatch, datInspectionDate);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Tow Motor Class // Find Tow Motor Inspection By Date Match " + Ex.Message);
            }

            return aFindTowMotorInspectionByDateMatchDataSet;
        }
        public bool InsertTowMotorInspection(int intTowMotorID, int intEmployeeID, int intWarehouseID, string strInspectionType, decimal decHourReading, DateTime datInspectionDate)
        {
            bool blnFatalError = false;

            try
            {
                aInsertTowMotorInspectionTableAdapter = new InsertTowMotorInspectionEntryTableAdapters.QueriesTableAdapter();
                aInsertTowMotorInspectionTableAdapter.InsertTowMotorInspection(intTowMotorID, intEmployeeID, intWarehouseID, strInspectionType, decHourReading, datInspectionDate);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Tow Motor Class // Insert Tow Motor Inspection " + Ex.Message);

                blnFatalError = true;
            }

            return blnFatalError;
        }
        public TowMotorInspectionDataSet GetTowMotorInspectionInfo()
        {
            try
            {
                aTowMotorInspectionDataSet = new TowMotorInspectionDataSet();
                aTowMotorInspectionTableAdapter = new TowMotorInspectionDataSetTableAdapters.towmotorinspectionTableAdapter();
                aTowMotorInspectionTableAdapter.Fill(aTowMotorInspectionDataSet.towmotorinspection);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Tow Motor Class // Get Tow Motor Inspection Info " + Ex.Message); 
            }

            return aTowMotorInspectionDataSet;
        }
        public void UpdateTowMotorInspectionDB(TowMotorInspectionDataSet aTowMotorInspectionDataSet)
        {
            try
            {
                aTowMotorInspectionTableAdapter = new TowMotorInspectionDataSetTableAdapters.towmotorinspectionTableAdapter();
                aTowMotorInspectionTableAdapter.Update(aTowMotorInspectionDataSet.towmotorinspection);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Tow Motor Class // Update Tow Motor Inspection DB " + Ex.Message);
            }
        }
        public FindTowMotorMainByWarehouseIDDataSet FindTowMotorMainByWarehouseID(int intWarehouseID)
        {
            try
            {
                aFindTowMotorMainByWarehouseIDDataSet = new FindTowMotorMainByWarehouseIDDataSet();
                aFindTowMotorMainByWarehouseIDTableAdapter = new FindTowMotorMainByWarehouseIDDataSetTableAdapters.FindTowMotorMainByWarehouseIDTableAdapter();
                aFindTowMotorMainByWarehouseIDTableAdapter.Fill(aFindTowMotorMainByWarehouseIDDataSet.FindTowMotorMainByWarehouseID, intWarehouseID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Tow Motor Class // Find Tow Motor Main By Warehouse ID " + Ex.Message);
            }

            return aFindTowMotorMainByWarehouseIDDataSet;
        }
        public FindTowMotorMainByTowMotorIDDataSet FindTowMotorMainByTowMotorID(int intTowMotorID)
        {
            try
            {
                aFindTowMotorMainByTowMotorIDDataSet = new FindTowMotorMainByTowMotorIDDataSet();
                aFindTowMotorMainByTowMotorIDTableAdapter = new FindTowMotorMainByTowMotorIDDataSetTableAdapters.FindTowMotorMainByTowMotorIDTableAdapter();
                aFindTowMotorMainByTowMotorIDTableAdapter.Fill(aFindTowMotorMainByTowMotorIDDataSet.FindTowMotorMainByTowMotorID, intTowMotorID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Tow Motor Class // Find Tow Motor Main By Tow Motor ID " + Ex.Message);
            }

            return aFindTowMotorMainByTowMotorIDDataSet;
        }
        public FindActiveTowMotorMainDataSet FindActiveTowMotorMain()
        {
            try
            {
                aFindActiveTowMotorMainDataSet = new FindActiveTowMotorMainDataSet();
                aFindActiveTowMotorMainTableAdapter = new FindActiveTowMotorMainDataSetTableAdapters.FindActiveTowMotorMainTableAdapter();
                aFindActiveTowMotorMainTableAdapter.Fill(aFindActiveTowMotorMainDataSet.FindActiveTowMotorMain);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Tow Motor Class // Find Active Tow Motor Main " + Ex.Message);
            }

            return aFindActiveTowMotorMainDataSet;
        }
        public bool UpdateTowMotorMainHours(int intTowMotorID, decimal decTowMotorHours)
        {
            bool blnFatalError = false;

            try
            {
                aUpdateTowMotorMainHoursTableAdapter = new UpdateTowMotorMainHoursEntryTableAdapters.QueriesTableAdapter();
                aUpdateTowMotorMainHoursTableAdapter.UpdateTowMotorMainHours(intTowMotorID, decTowMotorHours);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Tow Motor Class // Update Tow Motor Main Hours " + Ex.Message);

                blnFatalError = true;
            }

            return blnFatalError;
        }
        public bool UpdateTowMotorMainOilChangeDate(int intTowMotorID, DateTime datOilChangeDate)
        {
            bool blnFatalError = false;

            try
            {
                aUpdateTowMotorMainOilChangeDateTableAdapter = new UpdateTowMotorMainOilChangeDateEntryTableAdapters.QueriesTableAdapter();
                aUpdateTowMotorMainOilChangeDateTableAdapter.UpdateTowMotorMainOilChangeDate(intTowMotorID, datOilChangeDate);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Tow Motor Class // Update Tow Motor Main Oil Change Date " + Ex.Message);

                blnFatalError = true;
            }

            return blnFatalError;
        }
        public bool UpdateTowMotorMainActive(int intTowMotorID, bool blnActive)
        {
            bool blnFatalError = false;

            try
            {
                aUpdateTowMotorMainActiveTableAdapter = new UpdateTowMotorMainActiveEntryTableAdapters.QueriesTableAdapter();
                aUpdateTowMotorMainActiveTableAdapter.UpdateTowMotorMainActive(intTowMotorID, blnActive);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Tow Motor Class // Update Tow Motor Main Active " + Ex.Message);

                blnFatalError = true;
            }

            return blnFatalError;
        }
        public bool InsertTowMotorMain(string strTowMotorNumber, int intTowMotorYear, string strTowMotorMake, string strTowMotorModel, string strTowMotorSerialNo, decimal decTowMotorHours, int intWarehouseID, DateTime datOilChangeDate, bool blnTowMotorActive)
        {
            bool blnFatalError = false;

            try
            {
                aInsertTowMotorMainTableAdapter = new InsertTowMotorMainEntryTableAdapters.QueriesTableAdapter();
                aInsertTowMotorMainTableAdapter.InsertTowMotorMain(strTowMotorNumber, intTowMotorYear, strTowMotorMake, strTowMotorModel, strTowMotorSerialNo, decTowMotorHours, intWarehouseID, datOilChangeDate, blnTowMotorActive);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Tow Motor Class // Insert Tow Motor Main " + Ex.Message);

                blnFatalError = true;
            }

            return blnFatalError;
        }
        public TowMotorMainDataSet GetTowMotorMainInfo()
        {
            try
            {
                aTowMotorMainDataSet = new TowMotorMainDataSet();
                aTowMotorMainTableAdapter = new TowMotorMainDataSetTableAdapters.towmotormainTableAdapter();
                aTowMotorMainTableAdapter.Fill(aTowMotorMainDataSet.towmotormain);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Tow Motor Class // Get Tow Motor Info " + Ex.Message);
            }

            return aTowMotorMainDataSet;
        }
        public void UpdateTowMotorMainDB(TowMotorMainDataSet aTowMotorMainDataSet)
        {
            try
            {
                aTowMotorMainTableAdapter = new TowMotorMainDataSetTableAdapters.towmotormainTableAdapter();
                aTowMotorMainTableAdapter.Update(aTowMotorMainDataSet.towmotormain);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Tow Motor Class // Update Tow Motor DB " + Ex.Message);
            }
        }
    }
}

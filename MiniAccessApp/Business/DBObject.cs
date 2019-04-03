using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MiniAccessApp.Business;
using DAO;

namespace MiniAccessApp.Business
{
    //class DBObject
    //{
    //    private string dbPath;
    //    private DBEngine dbe;
    //    private Database myDB;
    //    private List<TableDef> ListOfTables;
    //    private List<Relation> ListOfRelations;
    //    public string DbPath { get => dbPath; set => dbPath = value; }
    //    public DBEngine Dbe { get => dbe; set => dbe = value; }
    //    public Database MyDB { get => myDB; set => myDB = value; }

    //    public DBObject()       {        }

    //    public DBObject(string dbPathString)
    //    {
    //        this.dbe = new DBEngine();
    //        try
    //        {
    //            this.myDB = dbe.OpenDatabase(dbPathString);
    //            //getting tables
    //            foreach (TableDef myTable in myDB.TableDefs)
    //            {
    //               if (myTable.Attributes == 0)
    //                {
    //                    ListOfTables.Add(myTable);
    //                }
    //            }
    //            //Reading DB relations schemas
    //            foreach (Relation myRel in myDB.Relations)
    //            {
    //                if (myRel.Attributes == 0)
    //                {
    //                    ListOfRelations.Add(myRel);
    //                }
    //            }
    //        }
    //        catch (Exception ex)
    //        {
    //            try
    //            {
    //                myDB.Close();
    //            }
    //            catch (Exception exx)
    //            {
    //                //Errors openning DBase
    //            }
    //        }
    //    }
    //}
}

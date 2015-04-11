using FormDatabasesMerge.EntityDataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FormDatabasesMerge.Utility
{
    public class DataConverter
    {
        public static FormDatabasesMerge.EntityDataModel.GeneralDatabaseModel.PRIZ FromSinglePRIZ(
            FormDatabasesMerge.EntityDataModel.SingleDatabaseModel.PRIZ priz, 
            int id,
            int komID,
            string summonYear, 
            string summonNumber,
            DateTime date,
            TimeSpan time)
        {
            FormDatabasesMerge.EntityDataModel.GeneralDatabaseModel.PRIZ p = new FormDatabasesMerge.EntityDataModel.GeneralDatabaseModel.PRIZ();
            p.BEZ_ROD = priz.BEZ_ROD;
            p.BRAK = priz.BRAK;
            p.D_DOP = priz.D_DOP;
            p.D_P_UVOL = priz.D_P_UVOL;
            p.D_PASPORT = priz.D_PASPORT;
            p.D_PRIB = priz.D_PRIB;
            p.D_ROD = priz.D_ROD;
            p.D_U_SOCH = priz.D_U_SOCH;
            p.D_U_UVOL = priz.D_U_UVOL;
            p.DO_PRIZ = priz.DO_PRIZ;
            p.F_DOP = priz.F_DOP;
            p.FAM = priz.FAM;
            p.FL_SOCH = priz.FL_SOCH;
            p.FL_UB = priz.FL_UB;
            p.FL_UV = priz.FL_UV;
            p.GODN = priz.GODN;
            p.H = priz.H;
            p.HIST = priz.HIST;
            p.IM = priz.IM;
            p.IMEET_RAZR = priz.IMEET_RAZR;
            p.IMEET_REB = priz.IMEET_REB;
            p.KEM_VIDAN = priz.KEM_VIDAN;
            p.LN_NUM = priz.LN_NUM;
            p.LN_SER = priz.LN_SER;
            p.M_ROD = priz.M_ROD;
            p.MASSA = priz.MASSA;
            p.N_DOP = priz.N_DOP;
            p.N_KOM = priz.N_KOM;
            p.N_PASPORT = priz.N_PASPORT;
            p.N_V_BIL = priz.N_V_BIL;
            p.N_VA = priz.N_VA;
            p.NA_UCHETE = priz.NA_UCHETE;
            p.NAVY = priz.NAVY;
            p.NPU = priz.NPU;
            p.OBRAZOV = priz.OBRAZOV;
            p.ODIN_ROD = priz.ODIN_ROD;
            p.OTCH = priz.OTCH;
            p.P_PREDN = priz.P_PREDN;
            p.POSTO = priz.POSTO;
            p.PR_UBIT = priz.PR_UBIT;
            p.PRIM = priz.PRIM;
            p.PRIM_UBIT = priz.PRIM_UBIT;
            p.PROF_P = priz.PROF_P;
            p.R_G_U = priz.R_G_U;
            p.R_O_G = priz.R_O_G;
            p.R_OB = priz.R_OB;
            p.REZH_KOM = priz.REZH_KOM;
            p.ROST = priz.ROST;
            p.RVK = priz.RVK;
            p.S_PASPORT = priz.S_PASPORT;
            p.S_V_BIL = priz.S_V_BIL;
            p.S_VA = priz.S_VA;
            p.SPEC = priz.SPEC;
            p.STAT = priz.STAT;
            p.SUD = priz.SUD;
            p.TDT = priz.TDT;
            p.TSP = priz.TSP;
            p.ZREN = priz.ZREN;

            p.SeasonID = priz.ID;

            p.SeasonYear = summonYear;
            p.SeasonNumber = summonNumber;
            p.MergeDate = date;
            p.MergeTime = time;

            p.ID = id;

            p.KomID = komID;

            return p;
        }

        public static FormDatabasesMerge.EntityDataModel.GeneralDatabaseModel.kom FromSinglekom(
            FormDatabasesMerge.EntityDataModel.SingleDatabaseModel.kom kom,
            int id,
            string summonYear,
            string summonNumber,
            DateTime date,
            TimeSpan time)
        {
            FormDatabasesMerge.EntityDataModel.GeneralDatabaseModel.kom k = new FormDatabasesMerge.EntityDataModel.GeneralDatabaseModel.kom();
            k.D_DOV = kom.D_DOV;
            k.D_OTPR = kom.D_OTPR;
            k.D_PR = kom.D_PR;
            k.D_VID = kom.D_VID;
            k.DOLJNOST = kom.DOLJNOST;
            k.DOPUSK = kom.DOPUSK;
            k.DVESHAT = kom.DVESHAT;
            k.FL_DISPLAY = kom.FL_DISPLAY;
            k.FL_PEREOD = kom.FL_PEREOD;
            k.FL_UB = kom.FL_UB;
            k.FOLLOW_OFICER = kom.FOLLOW_OFICER;
            k.FOLLOW_PRAPOR = kom.FOLLOW_PRAPOR;
            k.FOLLOW_SOLDERS = kom.FOLLOW_SOLDERS;
            k.GOROD = kom.GOROD;
            k.ISSIBVO = kom.ISSIBVO;
            k.KOLSUHPAY = kom.KOLSUHPAY;
            k.MTLB = kom.MTLB;
            k.N_DOV = kom.N_DOV;
            k.N_E = kom.N_E;
            k.N_KOM = kom.N_KOM;
            k.N_UD = kom.N_UD;
            k.NARAD = kom.NARAD;
            k.NVESHAT = kom.NVESHAT;
            k.PHONE = kom.PHONE;
            k.POEZD = kom.POEZD;
            k.PR = kom.PR;
            k.PREDS = kom.PREDS;
            k.PRIM = kom.PRIM;
            k.RAILROAD = kom.RAILROAD;
            k.REZH_KOM = kom.REZH_KOM;
            k.S_UD = kom.S_UD;
            k.SPEC = kom.SPEC;
            k.ST = kom.ST;
            k.STREET = kom.STREET;
            k.SUD = kom.SUD;
            k.SYST = kom.SYST;
            k.T_OTPR = kom.T_OTPR;
            k.V_CH = kom.V_CH;
            k.V_OKRUG = kom.V_OKRUG;
            k.V_SHET = kom.V_SHET;
            k.V_VS = kom.V_VS;
            k.VA = kom.VA;
            k.VID_TR = kom.VID_TR;
            k.VIDAN = kom.VIDAN;
            k.VSEGO = kom.VSEGO;
            k.VUS1 = kom.VUS1;
            k.VUS2 = kom.VUS2;
            k.VUS3 = kom.VUS3;
            k.Z_PREDS = kom.Z_PREDS;
            k.ZIP = kom.ZIP;

            k.SeasonID = kom.ID;

            k.SeasonYear = summonYear;
            k.SeasonNumber = summonNumber;
            k.MergeDate = date;
            k.MergeTime = time;

            k.ID = id;

            return k;
        }
    }
}

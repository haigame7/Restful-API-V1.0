//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace HaiGame7.Model.EFModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class db_GameInfoofPlatform
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public db_GameInfoofPlatform()
        {
            this.db_CommonUseHero = new HashSet<db_CommonUseHero>();
        }
    
        public int GamePlatformID { get; set; }
        public Nullable<int> UGID { get; set; }
        public string GameName { get; set; }
        public string GameLevel { get; set; }
        public string GameImage { get; set; }
        public string GameGrade { get; set; }
        public string GamePower { get; set; }
        public Nullable<decimal> GameKill { get; set; }
        public Nullable<decimal> GameDeath { get; set; }
        public Nullable<decimal> GameAssist { get; set; }
        public Nullable<decimal> KDAAbility { get; set; }
        public Nullable<decimal> FarmAbility { get; set; }
        public Nullable<decimal> PushAbility { get; set; }
        public Nullable<decimal> AliveAbility { get; set; }
        public Nullable<decimal> OutputAbility { get; set; }
        public Nullable<decimal> CompreAbility { get; set; }
        public Nullable<int> GameNum { get; set; }
        public Nullable<decimal> GameOdds { get; set; }
        public Nullable<double> GameKDA { get; set; }
        public byte[] System { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<db_CommonUseHero> db_CommonUseHero { get; set; }
        public virtual db_GameIDofUser db_GameIDofUser { get; set; }
    }
}

﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IIS.Sektor_podbora_i_razvitiya_personala
{
    using System;
    using System.Xml;
    using ICSSoft.STORMNET;
    
    
    // *** Start programmer edit section *** (Using statements)

    // *** End programmer edit section *** (Using statements)


    /// <summary>
    /// Рекомендац.
    /// </summary>
    // *** Start programmer edit section *** (Рекомендац CustomAttributes)

    // *** End programmer edit section *** (Рекомендац CustomAttributes)
    [AutoAltered()]
    [Caption("Рекомендации для улучшения ситуации в компании")]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    [View("РекомендацE", new string[] {
            "Специалисты as \'Специалисты\'",
            "Руководители as \'Руководители\'",
            "Рабочие as \'Рабочие\'"})]
    public class Рекомендац : ICSSoft.STORMNET.DataObject
    {
        
        private string fСпециалисты;
        
        private string fРуководители;
        
        private string fРабочие;
        
        private IIS.Sektor_podbora_i_razvitiya_personala.ПричинУвольн fПричинУвольн;
        
        // *** Start programmer edit section *** (Рекомендац CustomMembers)

        // *** End programmer edit section *** (Рекомендац CustomMembers)

        
        /// <summary>
        /// Рабочие.
        /// </summary>
        // *** Start programmer edit section *** (Рекомендац.Рабочие CustomAttributes)

        // *** End programmer edit section *** (Рекомендац.Рабочие CustomAttributes)
        [StrLen(255)]
        public virtual string Рабочие
        {
            get
            {
                // *** Start programmer edit section *** (Рекомендац.Рабочие Get start)

                // *** End programmer edit section *** (Рекомендац.Рабочие Get start)
                string result = this.fРабочие;
                // *** Start programmer edit section *** (Рекомендац.Рабочие Get end)

                // *** End programmer edit section *** (Рекомендац.Рабочие Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Рекомендац.Рабочие Set start)

                // *** End programmer edit section *** (Рекомендац.Рабочие Set start)
                this.fРабочие = value;
                // *** Start programmer edit section *** (Рекомендац.Рабочие Set end)

                // *** End programmer edit section *** (Рекомендац.Рабочие Set end)
            }
        }
        
        /// <summary>
        /// Руководители.
        /// </summary>
        // *** Start programmer edit section *** (Рекомендац.Руководители CustomAttributes)

        // *** End programmer edit section *** (Рекомендац.Руководители CustomAttributes)
        [StrLen(255)]
        public virtual string Руководители
        {
            get
            {
                // *** Start programmer edit section *** (Рекомендац.Руководители Get start)

                // *** End programmer edit section *** (Рекомендац.Руководители Get start)
                string result = this.fРуководители;
                // *** Start programmer edit section *** (Рекомендац.Руководители Get end)

                // *** End programmer edit section *** (Рекомендац.Руководители Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Рекомендац.Руководители Set start)

                // *** End programmer edit section *** (Рекомендац.Руководители Set start)
                this.fРуководители = value;
                // *** Start programmer edit section *** (Рекомендац.Руководители Set end)

                // *** End programmer edit section *** (Рекомендац.Руководители Set end)
            }
        }
        
        /// <summary>
        /// Специалисты.
        /// </summary>
        // *** Start programmer edit section *** (Рекомендац.Специалисты CustomAttributes)

        // *** End programmer edit section *** (Рекомендац.Специалисты CustomAttributes)
        [StrLen(255)]
        public virtual string Специалисты
        {
            get
            {
                // *** Start programmer edit section *** (Рекомендац.Специалисты Get start)

                // *** End programmer edit section *** (Рекомендац.Специалисты Get start)
                string result = this.fСпециалисты;
                // *** Start programmer edit section *** (Рекомендац.Специалисты Get end)

                // *** End programmer edit section *** (Рекомендац.Специалисты Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Рекомендац.Специалисты Set start)

                // *** End programmer edit section *** (Рекомендац.Специалисты Set start)
                this.fСпециалисты = value;
                // *** Start programmer edit section *** (Рекомендац.Специалисты Set end)

                // *** End programmer edit section *** (Рекомендац.Специалисты Set end)
            }
        }
        
        /// <summary>
        /// мастеровая ссылка на шапку IIS.Sektor_podbora_i_razvitiya_personala.ПричинУвольн.
        /// </summary>
        // *** Start programmer edit section *** (Рекомендац.ПричинУвольн CustomAttributes)

        // *** End programmer edit section *** (Рекомендац.ПричинУвольн CustomAttributes)
        [Agregator()]
        [NotNull()]
        [PropertyStorage(new string[] {
                "ПричинУвольн"})]
        public virtual IIS.Sektor_podbora_i_razvitiya_personala.ПричинУвольн ПричинУвольн
        {
            get
            {
                // *** Start programmer edit section *** (Рекомендац.ПричинУвольн Get start)

                // *** End programmer edit section *** (Рекомендац.ПричинУвольн Get start)
                IIS.Sektor_podbora_i_razvitiya_personala.ПричинУвольн result = this.fПричинУвольн;
                // *** Start programmer edit section *** (Рекомендац.ПричинУвольн Get end)

                // *** End programmer edit section *** (Рекомендац.ПричинУвольн Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Рекомендац.ПричинУвольн Set start)

                // *** End programmer edit section *** (Рекомендац.ПричинУвольн Set start)
                this.fПричинУвольн = value;
                // *** Start programmer edit section *** (Рекомендац.ПричинУвольн Set end)

                // *** End programmer edit section *** (Рекомендац.ПричинУвольн Set end)
            }
        }
        
        /// <summary>
        /// Class views container.
        /// </summary>
        public class Views
        {
            
            /// <summary>
            /// "РекомендацE" view.
            /// </summary>
            public static ICSSoft.STORMNET.View РекомендацE
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("РекомендацE", typeof(IIS.Sektor_podbora_i_razvitiya_personala.Рекомендац));
                }
            }
        }
    }
    
    /// <summary>
    /// Detail array of Рекомендац.
    /// </summary>
    // *** Start programmer edit section *** (DetailArrayDetailArrayOfРекомендац CustomAttributes)

    // *** End programmer edit section *** (DetailArrayDetailArrayOfРекомендац CustomAttributes)
    public class DetailArrayOfРекомендац : ICSSoft.STORMNET.DetailArray
    {
        
        // *** Start programmer edit section *** (IIS.Sektor_podbora_i_razvitiya_personala.DetailArrayOfРекомендац members)

        // *** End programmer edit section *** (IIS.Sektor_podbora_i_razvitiya_personala.DetailArrayOfРекомендац members)

        
        /// <summary>
        /// Construct detail array.
        /// </summary>
        /// <summary>
        /// Returns object with type Рекомендац by index.
        /// </summary>
        /// <summary>
        /// Adds object with type Рекомендац.
        /// </summary>
        public DetailArrayOfРекомендац(IIS.Sektor_podbora_i_razvitiya_personala.ПричинУвольн fПричинУвольн) : 
                base(typeof(Рекомендац), ((ICSSoft.STORMNET.DataObject)(fПричинУвольн)))
        {
        }
        
        public IIS.Sektor_podbora_i_razvitiya_personala.Рекомендац this[int index]
        {
            get
            {
                return ((IIS.Sektor_podbora_i_razvitiya_personala.Рекомендац)(this.ItemByIndex(index)));
            }
        }
        
        public virtual void Add(IIS.Sektor_podbora_i_razvitiya_personala.Рекомендац dataobject)
        {
            this.AddObject(((ICSSoft.STORMNET.DataObject)(dataobject)));
        }
    }
}

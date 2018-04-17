// ***********************************************************************
// Assembly         : ACBr.Net.NFSe
// Author           : RFTD
// Created          : 05-26-2016
//
// Last Modified By : RFTD
// Last Modified On : 06-07-2016
// ***********************************************************************
// <copyright file="DadosPrestador.cs" company="ACBr.Net">
//		        		   The MIT License (MIT)
//	     		    Copyright (c) 2016 Grupo ACBr.Net
//
//	 Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the "Software"),
// to deal in the Software without restriction, including without limitation
// the rights to use, copy, modify, merge, publish, distribute, sublicense,
// and/or sell copies of the Software, and to permit persons to whom the
// Software is furnished to do so, subject to the following conditions:
//	 The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
//	 THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT.
// IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM,
// DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE,
// ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER
// DEALINGS IN THE SOFTWARE.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System.ComponentModel;
using ACBr.Net.Core.Generics;

namespace ACBr.Net.NFSe.Nota
{
    public sealed class DadosPrestador : GenericClone<DadosPrestador>, INotifyPropertyChanged
    {
        #region Events

        public event PropertyChangedEventHandler PropertyChanged;

        #endregion Events

        #region Constructors

        internal DadosPrestador()
        {
            CpfCnpj = string.Empty;
            InscricaoMunicipal = string.Empty;
            Senha = string.Empty;
            FraseSecreta = string.Empty;
            Endereco = new Endereco();
            DadosContato = new DadosContato();
        }

        #endregion Constructors

        #region Propriedades

        public string CpfCnpj { get; set; }

        public string InscricaoMunicipal { get; set; }

        public string Senha { get; set; }

        public string FraseSecreta { get; set; }

        public string ChaveAcesso { get; set; }

        public string RazaoSocial { get; set; }

        public string NomeFantasia { get; set; }

        public Endereco Endereco { get; }

        public DadosContato DadosContato { get; }

        #endregion Propriedades
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PortalSupCom.CA.RoboLinksDoctos.srvListSupCom;
using System.Net;

namespace PortalSupCom.CA.RoboLinksDoctos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----- PORTAL SUPORTE COMERCIAL - ROBÔ LINKS CONTROLE DE DOCUMENTOS -----");
            Console.WriteLine("\n\n");

            string vLinkAntigo = @"fsb2w02/SUPPLY CHAIN/Reposicao/6.gerencia suporte_anteriores/Planejamento/17. Contratos/Documentos dos Fornecedores";
            string vLinkNovo = @"fsb2w02/Documentos_dos_Fornecedores";

            Config itemConfig = new Config();

            B2WPortalSuporteComercialDataContext dc = new B2WPortalSuporteComercialDataContext(new Uri(itemConfig.uri));
            dc.Credentials = new NetworkCredential(itemConfig.user, itemConfig.password, itemConfig.domain);

            ControleDeDocumentosItem edititem = null;
            int vCount;

            //===== Atualizando campo Cartão CNPJ
            Console.WriteLine("Verificando Cartão CNPJ...");
            
            var queryDoctos1 = (from lstDoctos in dc.ControleDeDocumentos
                               where lstDoctos.CartãoCNPJ.Contains("SUPPLY CHAIN")
                               select new { CampoID = lstDoctos.ID, CampoLink = lstDoctos.CartãoCNPJ });
            
            if (queryDoctos1.Count() > 0)
            {
                Console.WriteLine("{0} registros encontrados.", queryDoctos1.Count());
                Console.WriteLine("\n");
                Console.WriteLine("Processando Cartão CNPJ...");

                edititem = null;
                vCount = 0;
              
                foreach (var itemDocto in queryDoctos1)
                {
                    edititem = dc.ControleDeDocumentos
                                .Where(i => i.ID == itemDocto.CampoID)
                                .FirstOrDefault();
                   
                    edititem.CartãoCNPJ = itemDocto.CampoLink.Replace(vLinkAntigo, vLinkNovo);

                    dc.UpdateObject(edititem);
                    dc.SaveChanges();
                    
                    vCount = vCount +1;
                }
                Console.WriteLine("{0} registros atualizados!",vCount);
            }
            else
            {
                Console.WriteLine("Nenhum registro encontrado!");
            }

            Console.WriteLine("\n");
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("\n");


            //===== Atualizando campo Doc. Optante Simples/Declaração Regime Tributário
            Console.WriteLine("Verificando Doc. Optante Simples/Declaração Regime Tributário...");

            var queryDoctos2 = (from lstDoctos in dc.ControleDeDocumentos
                                where lstDoctos.DocOptanteSimplesDeclaraçãoRegimeTributário.Contains("SUPPLY CHAIN")
                                select new { CampoID = lstDoctos.ID, CampoLink = lstDoctos.DocOptanteSimplesDeclaraçãoRegimeTributário });

            if (queryDoctos2.Count() > 0)
            {
                Console.WriteLine("{0} registros encontrados.", queryDoctos2.Count());
                Console.WriteLine("\n");
                Console.WriteLine("Processando Doc. Optante Simples/Declaração Regime Tributário...");

                edititem = null;
                vCount = 0;

                foreach (var itemDocto in queryDoctos2)
                {
                    edititem = dc.ControleDeDocumentos
                                .Where(i => i.ID == itemDocto.CampoID)
                                .FirstOrDefault();

                    edititem.DocOptanteSimplesDeclaraçãoRegimeTributário = itemDocto.CampoLink.Replace(vLinkAntigo, vLinkNovo);

                    dc.UpdateObject(edititem);
                    dc.SaveChanges();

                    vCount = vCount + 1;
                }
                Console.WriteLine("{0} registros atualizados!", vCount);
            }
            else
            {
                Console.WriteLine("Nenhum registro encontrado!");
            }

            Console.WriteLine("\n");
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("\n");

            
            //===== Atualizando  campo Doc. SINTEGRA - ICMS
            Console.WriteLine("Verificando Doc. SINTEGRA - ICMS...");

            var queryDoctos3 = (from lstDoctos in dc.ControleDeDocumentos
                                where lstDoctos.DocSINTEGRAICMS.Contains("SUPPLY CHAIN")
                                select new { CampoID = lstDoctos.ID, CampoLink = lstDoctos.DocSINTEGRAICMS });

            if (queryDoctos3.Count() > 0)
            {
                Console.WriteLine("{0} registros encontrados.", queryDoctos3.Count());
                Console.WriteLine("\n");
                Console.WriteLine("Processando Doc. SINTEGRA - ICMS...");

                edititem = null;
                vCount = 0;

                foreach (var itemDocto in queryDoctos3)
                {
                    edititem = dc.ControleDeDocumentos
                                .Where(i => i.ID == itemDocto.CampoID)
                                .FirstOrDefault();

                    edititem.DocSINTEGRAICMS = itemDocto.CampoLink.Replace(vLinkAntigo, vLinkNovo);

                    dc.UpdateObject(edititem);
                    dc.SaveChanges();

                    vCount = vCount + 1;
                }
                Console.WriteLine("{0} registros atualizados!", vCount);
            }
            else
            {
                Console.WriteLine("Nenhum registro encontrado!");
            }

            Console.WriteLine("\n");
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("\n");


            //===== Atualizando  campo Doc. Alvará de Funcionamento
            Console.WriteLine("Verificando Doc. Alvará de Funcionamento...");

            var queryDoctos4 = (from lstDoctos in dc.ControleDeDocumentos
                                where lstDoctos.DocAlvaráDeFuncionamento.Contains("SUPPLY CHAIN")
                                select new { CampoID = lstDoctos.ID, CampoLink = lstDoctos.DocAlvaráDeFuncionamento });

            if (queryDoctos4.Count() > 0)
            {
                Console.WriteLine("{0} registros encontrados.", queryDoctos4.Count());
                Console.WriteLine("\n");
                Console.WriteLine("Processando Doc. Alvará de Funcionamento...");

                edititem = null;
                vCount = 0;

                foreach (var itemDocto in queryDoctos4)
                {
                    edititem = dc.ControleDeDocumentos
                                .Where(i => i.ID == itemDocto.CampoID)
                                .FirstOrDefault();

                    edititem.DocAlvaráDeFuncionamento = itemDocto.CampoLink.Replace(vLinkAntigo, vLinkNovo);

                    dc.UpdateObject(edititem);
                    dc.SaveChanges();

                    vCount = vCount + 1;
                }
                Console.WriteLine("{0} registros atualizados!", vCount);
            }
            else
            {
                Console.WriteLine("Nenhum registro encontrado!");
            }

            Console.WriteLine("\n");
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("\n");


            //===== Atualizando  campo Doc. CN de Débitos Tributário
            Console.WriteLine("Verificando Doc. CN de Débitos Tributário...");

            var queryDoctos5 = (from lstDoctos in dc.ControleDeDocumentos
                                where lstDoctos.DocCNDeDébitosTributários.Contains("SUPPLY CHAIN")
                                select new { CampoID = lstDoctos.ID, CampoLink = lstDoctos.DocCNDeDébitosTributários });

            if (queryDoctos5.Count() > 0)
            {
                Console.WriteLine("{0} registros encontrados.", queryDoctos5.Count());
                Console.WriteLine("\n");
                Console.WriteLine("Processando Doc. CN de Débitos Tributário...");

                edititem = null;
                vCount = 0;

                foreach (var itemDocto in queryDoctos5)
                {
                    edititem = dc.ControleDeDocumentos
                                .Where(i => i.ID == itemDocto.CampoID)
                                .FirstOrDefault();

                    edititem.DocCNDeDébitosTributários = itemDocto.CampoLink.Replace(vLinkAntigo, vLinkNovo);

                    dc.UpdateObject(edititem);
                    dc.SaveChanges();

                    vCount = vCount + 1;
                }
                Console.WriteLine("{0} registros atualizados!", vCount);
            }
            else
            {
                Console.WriteLine("Nenhum registro encontrado!");
            }

            Console.WriteLine("\n");
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("\n");


            //===== Atualizando  campo Doc. CN de Débitos Trabalhistas
            Console.WriteLine("Verificando Doc. CN de Débitos Trabalhistas...");

            var queryDoctos6 = (from lstDoctos in dc.ControleDeDocumentos
                                where lstDoctos.DocCNDeDébitosTrabalhistas.Contains("SUPPLY CHAIN")
                                select new { CampoID = lstDoctos.ID, CampoLink = lstDoctos.DocCNDeDébitosTrabalhistas });

            if (queryDoctos6.Count() > 0)
            {
                Console.WriteLine("{0} registros encontrados.", queryDoctos6.Count());
                Console.WriteLine("\n");
                Console.WriteLine("Processando Doc. CN de Débitos Trabalhistas...");

                edititem = null;
                vCount = 0;

                foreach (var itemDocto in queryDoctos6)
                {
                    edititem = dc.ControleDeDocumentos
                                .Where(i => i.ID == itemDocto.CampoID)
                                .FirstOrDefault();

                    edititem.DocCNDeDébitosTrabalhistas = itemDocto.CampoLink.Replace(vLinkAntigo, vLinkNovo);

                    dc.UpdateObject(edititem);
                    dc.SaveChanges();

                    vCount = vCount + 1;
                }
                Console.WriteLine("{0} registros atualizados!", vCount);
            }
            else
            {
                Console.WriteLine("Nenhum registro encontrado!");
            }

            Console.WriteLine("\n");
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("\n");


            //===== Atualizando  campo Doc. CN de Débitos Previdenciários
            Console.WriteLine("Verificando Doc. CN de Débitos Previdenciários...");

            var queryDoctos7 = (from lstDoctos in dc.ControleDeDocumentos
                                where lstDoctos.DocCNDeDébitosPrevidenciários.Contains("SUPPLY CHAIN")
                                select new { CampoID = lstDoctos.ID, CampoLink = lstDoctos.DocCNDeDébitosPrevidenciários });

            if (queryDoctos7.Count() > 0)
            {
                Console.WriteLine("{0} registros encontrados.", queryDoctos7.Count());
                Console.WriteLine("\n");
                Console.WriteLine("Processando Doc. CN de Débitos Previdenciários...");

                edititem = null;
                vCount = 0;

                foreach (var itemDocto in queryDoctos7)
                {
                    edititem = dc.ControleDeDocumentos
                                .Where(i => i.ID == itemDocto.CampoID)
                                .FirstOrDefault();

                    edititem.DocCNDeDébitosPrevidenciários = itemDocto.CampoLink.Replace(vLinkAntigo, vLinkNovo);

                    dc.UpdateObject(edititem);
                    dc.SaveChanges();

                    vCount = vCount + 1;
                }
                Console.WriteLine("{0} registros atualizados!", vCount);
            }
            else
            {
                Console.WriteLine("Nenhum registro encontrado!");
            }

            Console.WriteLine("\n");
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("\n");


            //===== Atualizando  campo Doc. CN de Falência e Concordata (matriz)
            Console.WriteLine("Verificando Doc. CN de Falência e Concordata (matriz)...");

            var queryDoctos8 = (from lstDoctos in dc.ControleDeDocumentos
                                where lstDoctos.DocCNDeFalênciaEConcordataMatriz.Contains("SUPPLY CHAIN")
                                select new { CampoID = lstDoctos.ID, CampoLink = lstDoctos.DocCNDeFalênciaEConcordataMatriz });

            if (queryDoctos8.Count() > 0)
            {
                Console.WriteLine("{0} registros encontrados.", queryDoctos8.Count());
                Console.WriteLine("\n");
                Console.WriteLine("Processando Doc. CN de Falência e Concordata (matriz)...");

                edititem = null;
                vCount = 0;

                foreach (var itemDocto in queryDoctos8)
                {
                    edititem = dc.ControleDeDocumentos
                                .Where(i => i.ID == itemDocto.CampoID)
                                .FirstOrDefault();

                    edititem.DocCNDeFalênciaEConcordataMatriz = itemDocto.CampoLink.Replace(vLinkAntigo, vLinkNovo);

                    dc.UpdateObject(edititem);
                    dc.SaveChanges();

                    vCount = vCount + 1;
                }
                Console.WriteLine("{0} registros atualizados!", vCount);
            }
            else
            {
                Console.WriteLine("Nenhum registro encontrado!");
            }

            Console.WriteLine("\n");
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("\n");


            //===== Atualizando  campo Doc. CN de Falência e Concordata (filiais)
            Console.WriteLine("Verificando Doc. CN de Falência e Concordata (filiais)...");

            var queryDoctos9 = (from lstDoctos in dc.ControleDeDocumentos
                                where lstDoctos.DocCNDeFalênciaEConcordataFiliais.Contains("SUPPLY CHAIN")
                                select new { CampoID = lstDoctos.ID, CampoLink = lstDoctos.DocCNDeFalênciaEConcordataFiliais });

            if (queryDoctos9.Count() > 0)
            {
                Console.WriteLine("{0} registros encontrados.", queryDoctos9.Count());
                Console.WriteLine("\n");
                Console.WriteLine("Processando Doc. CN de Falência e Concordata (filiais)...");

                edititem = null;
                vCount = 0;

                foreach (var itemDocto in queryDoctos9)
                {
                    edititem = dc.ControleDeDocumentos
                                .Where(i => i.ID == itemDocto.CampoID)
                                .FirstOrDefault();

                    edititem.DocCNDeFalênciaEConcordataFiliais = itemDocto.CampoLink.Replace(vLinkAntigo, vLinkNovo);

                    dc.UpdateObject(edititem);
                    dc.SaveChanges();

                    vCount = vCount + 1;
                }
                Console.WriteLine("{0} registros atualizados!", vCount);
            }
            else
            {
                Console.WriteLine("Nenhum registro encontrado!");
            }

            Console.WriteLine("\n");
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("\n");


            //===== Atualizando  campo Doc. Certidão de Distribuidores Cíveis Estadual
            Console.WriteLine("Verificando Doc. Certidão de Distribuidores Cíveis Estadual...");

            var queryDoctos10 = (from lstDoctos in dc.ControleDeDocumentos
                                where lstDoctos.DocCertidãoDeDistribuidoresCíveisEstadual.Contains("SUPPLY CHAIN")
                                 select new { CampoID = lstDoctos.ID, CampoLink = lstDoctos.DocCertidãoDeDistribuidoresCíveisEstadual });

            if (queryDoctos10.Count() > 0)
            {
                Console.WriteLine("{0} registros encontrados.", queryDoctos10.Count());
                Console.WriteLine("\n");
                Console.WriteLine("Processando Doc. Certidão de Distribuidores Cíveis Estadual...");

                edititem = null;
                vCount = 0;

                foreach (var itemDocto in queryDoctos10)
                {
                    edititem = dc.ControleDeDocumentos
                                .Where(i => i.ID == itemDocto.CampoID)
                                .FirstOrDefault();

                    edititem.DocCertidãoDeDistribuidoresCíveisEstadual = itemDocto.CampoLink.Replace(vLinkAntigo, vLinkNovo);

                    dc.UpdateObject(edititem);
                    dc.SaveChanges();

                    vCount = vCount + 1;
                }
                Console.WriteLine("{0} registros atualizados!", vCount);
            }
            else
            {
                Console.WriteLine("Nenhum registro encontrado!");
            }

            Console.WriteLine("\n");
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("\n");


            //===== Atualizando  campo Doc. Certidões de Distribuidores Criminais Estadual (CNPJ matriz)
            Console.WriteLine("Verificando Doc. Certidões de Distribuidores Criminais Estadual (CNPJ matriz)...");

            var queryDoctos11 = (from lstDoctos in dc.ControleDeDocumentos
                                where lstDoctos.DocCertidõesDeDistribuidoresCriminaisEstadualCNPJMatriz.Contains("SUPPLY CHAIN")
                                 select new { CampoID = lstDoctos.ID, CampoLink = lstDoctos.DocCertidõesDeDistribuidoresCriminaisEstadualCNPJMatriz });

            if (queryDoctos11.Count() > 0)
            {
                Console.WriteLine("{0} registros encontrados.", queryDoctos11.Count());
                Console.WriteLine("\n");
                Console.WriteLine("Processando Doc. Certidões de Distribuidores Criminais Estadual (CNPJ matriz)...");

                edititem = null;
                vCount = 0;

                foreach (var itemDocto in queryDoctos11)
                {
                    edititem = dc.ControleDeDocumentos
                                .Where(i => i.ID == itemDocto.CampoID)
                                .FirstOrDefault();

                    edititem.DocCertidõesDeDistribuidoresCriminaisEstadualCNPJMatriz = itemDocto.CampoLink.Replace(vLinkAntigo, vLinkNovo);

                    dc.UpdateObject(edititem);
                    dc.SaveChanges();

                    vCount = vCount + 1;
                }
                Console.WriteLine("{0} registros atualizados!", vCount);
            }
            else
            {
                Console.WriteLine("Nenhum registro encontrado!");
            }

            Console.WriteLine("\n");
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("\n");


            //===== Atualizando  campo Doc. Certidões de Distribuidores Criminais Estadual (representantes legais)
            Console.WriteLine("Verificando Doc. Certidões de Distribuidores Criminais Estadual (representantes legais)...");

            var queryDoctos12 = (from lstDoctos in dc.ControleDeDocumentos
                                where lstDoctos.DocCertidõesDeDistribuidoresCriminaisEstadualRepresentantesLegais.Contains("SUPPLY CHAIN")
                                 select new { CampoID = lstDoctos.ID, CampoLink = lstDoctos.DocCertidõesDeDistribuidoresCriminaisEstadualRepresentantesLegais });

            if (queryDoctos12.Count() > 0)
            {
                Console.WriteLine("{0} registros encontrados.", queryDoctos12.Count());
                Console.WriteLine("\n");
                Console.WriteLine("Processando Doc. Certidões de Distribuidores Criminais Estadual (representantes legais)...");

                edititem = null;
                vCount = 0;

                foreach (var itemDocto in queryDoctos12)
                {
                    edititem = dc.ControleDeDocumentos
                                .Where(i => i.ID == itemDocto.CampoID)
                                .FirstOrDefault();

                    edititem.DocCertidõesDeDistribuidoresCriminaisEstadualRepresentantesLegais = itemDocto.CampoLink.Replace(vLinkAntigo, vLinkNovo);

                    dc.UpdateObject(edititem);
                    dc.SaveChanges();

                    vCount = vCount + 1;
                }
                Console.WriteLine("{0} registros atualizados!", vCount);
            }
            else
            {
                Console.WriteLine("Nenhum registro encontrado!");
            }

            Console.WriteLine("\n");
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("\n");


            //===== Atualizando  campo Doc. Certidão de Distribuição de Ações e Execuções Cíveis e Criminais Federal
            Console.WriteLine("Verificando Doc. Certidão de Distribuição de Ações e Execuções Cíveis e Criminais Federal...");

            var queryDoctos13 = (from lstDoctos in dc.ControleDeDocumentos
                                where lstDoctos.DocCertidãoDeDistribuiçãoDeAçõesEExecuçõesCíveisECriminaisFederal.Contains("SUPPLY CHAIN")
                                 select new { CampoID = lstDoctos.ID, CampoLink = lstDoctos.DocCertidãoDeDistribuiçãoDeAçõesEExecuçõesCíveisECriminaisFederal });

            if (queryDoctos13.Count() > 0)
            {
                Console.WriteLine("{0} registros encontrados.", queryDoctos13.Count());
                Console.WriteLine("\n");
                Console.WriteLine("Processando Doc. Certidão de Distribuição de Ações e Execuções Cíveis e Criminais Federal...");

                edititem = null;
                vCount = 0;

                foreach (var itemDocto in queryDoctos13)
                {
                    edititem = dc.ControleDeDocumentos
                                .Where(i => i.ID == itemDocto.CampoID)
                                .FirstOrDefault();

                    edititem.DocCertidãoDeDistribuiçãoDeAçõesEExecuçõesCíveisECriminaisFederal = itemDocto.CampoLink.Replace(vLinkAntigo, vLinkNovo);

                    dc.UpdateObject(edititem);
                    dc.SaveChanges();

                    vCount = vCount + 1;
                }
                Console.WriteLine("{0} registros atualizados!", vCount);
            }
            else
            {
                Console.WriteLine("Nenhum registro encontrado!");
            }

            Console.WriteLine("\n");
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("\n");


            //===== Atualizando  campo Doc. Contrato/Estatuto Social (constituição)
            Console.WriteLine("Verificando Doc. Contrato/Estatuto Social (constituição)...");

            var queryDoctos14 = (from lstDoctos in dc.ControleDeDocumentos
                                where lstDoctos.DocContratoEstatutoSocialConstituição.Contains("SUPPLY CHAIN")
                                 select new { CampoID = lstDoctos.ID, CampoLink = lstDoctos.DocContratoEstatutoSocialConstituição });

            if (queryDoctos14.Count() > 0)
            {
                Console.WriteLine("{0} registros encontrados.", queryDoctos14.Count());
                Console.WriteLine("\n");
                Console.WriteLine("Processando Doc. Contrato/Estatuto Social (constituição)...");

                edititem = null;
                vCount = 0;

                foreach (var itemDocto in queryDoctos14)
                {
                    edititem = dc.ControleDeDocumentos
                                .Where(i => i.ID == itemDocto.CampoID)
                                .FirstOrDefault();

                    edititem.DocContratoEstatutoSocialConstituição = itemDocto.CampoLink.Replace(vLinkAntigo, vLinkNovo);

                    dc.UpdateObject(edititem);
                    dc.SaveChanges();

                    vCount = vCount + 1;
                }
                Console.WriteLine("{0} registros atualizados!", vCount);
            }
            else
            {
                Console.WriteLine("Nenhum registro encontrado!");
            }

            Console.WriteLine("\n");
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("\n");


            //===== Atualizando  campo Doc. Contrato/Estatuto Social (última alteração)
            Console.WriteLine("Verificando Doc. Contrato/Estatuto Social (última alteração)...");

            var queryDoctos15 = (from lstDoctos in dc.ControleDeDocumentos
                                where lstDoctos.DocContratoEstatutoSocialÚltimaAlteração.Contains("SUPPLY CHAIN")
                                 select new { CampoID = lstDoctos.ID, CampoLink = lstDoctos.DocContratoEstatutoSocialÚltimaAlteração });

            if (queryDoctos15.Count() > 0)
            {
                Console.WriteLine("{0} registros encontrados.", queryDoctos15.Count());
                Console.WriteLine("\n");
                Console.WriteLine("Processando Doc. Contrato/Estatuto Social (última alteração)...");

                edititem = null;
                vCount = 0;

                foreach (var itemDocto in queryDoctos15)
                {
                    edititem = dc.ControleDeDocumentos
                                .Where(i => i.ID == itemDocto.CampoID)
                                .FirstOrDefault();

                    edititem.DocContratoEstatutoSocialÚltimaAlteração = itemDocto.CampoLink.Replace(vLinkAntigo, vLinkNovo);

                    dc.UpdateObject(edititem);
                    dc.SaveChanges();

                    vCount = vCount + 1;
                }
                Console.WriteLine("{0} registros atualizados!", vCount);
            }
            else
            {
                Console.WriteLine("Nenhum registro encontrado!");
            }

            Console.WriteLine("\n");
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("\n");


            //===== Atualizando  campo Doc. Certidão Simplificada do SINREM
            Console.WriteLine("Verificando Doc. Certidão Simplificada do SINREM...");

            var queryDoctos16 = (from lstDoctos in dc.ControleDeDocumentos
                                where lstDoctos.DocCertidãoSimplificadaDoSINREM.Contains("SUPPLY CHAIN")
                                 select new { CampoID = lstDoctos.ID, CampoLink = lstDoctos.DocCertidãoSimplificadaDoSINREM });

            if (queryDoctos16.Count() > 0)
            {
                Console.WriteLine("{0} registros encontrados.", queryDoctos16.Count());
                Console.WriteLine("\n");
                Console.WriteLine("Processando Doc. Certidão Simplificada do SINREM...");

                edititem = null;
                vCount = 0;

                foreach (var itemDocto in queryDoctos16)
                {
                    edititem = dc.ControleDeDocumentos
                                .Where(i => i.ID == itemDocto.CampoID)
                                .FirstOrDefault();

                    edititem.DocCertidãoSimplificadaDoSINREM = itemDocto.CampoLink.Replace(vLinkAntigo, vLinkNovo);

                    dc.UpdateObject(edititem);
                    dc.SaveChanges();

                    vCount = vCount + 1;
                }
                Console.WriteLine("{0} registros atualizados!", vCount);
            }
            else
            {
                Console.WriteLine("Nenhum registro encontrado!");
            }

            Console.WriteLine("\n");
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("\n");


            //===== Atualizando  campo Doc. Contrato de Fornecimento B2W
            Console.WriteLine("Verificando Doc. Contrato de Fornecimento B2W...");

            var queryDoctos17 = (from lstDoctos in dc.ControleDeDocumentos
                                where lstDoctos.DocContratoDeFornecimentoB2W.Contains("SUPPLY CHAIN")
                                 select new { CampoID = lstDoctos.ID, CampoLink = lstDoctos.DocContratoDeFornecimentoB2W });

            if (queryDoctos17.Count() > 0)
            {
                Console.WriteLine("{0} registros encontrados.", queryDoctos17.Count());
                Console.WriteLine("\n");
                Console.WriteLine("Processando Doc. Contrato de Fornecimento B2W...");

                edititem = null;
                vCount = 0;

                foreach (var itemDocto in queryDoctos17)
                {
                    edititem = dc.ControleDeDocumentos
                                .Where(i => i.ID == itemDocto.CampoID)
                                .FirstOrDefault();

                    edititem.DocContratoDeFornecimentoB2W = itemDocto.CampoLink.Replace(vLinkAntigo, vLinkNovo);

                    dc.UpdateObject(edititem);
                    dc.SaveChanges();

                    vCount = vCount + 1;
                }
                Console.WriteLine("{0} registros atualizados!", vCount);
            }
            else
            {
                Console.WriteLine("Nenhum registro encontrado!");
            }

            Console.WriteLine("\n");
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("\n");


            //===== Atualizando  campo Doc. RG e CPF
            Console.WriteLine("Verificando Doc. RG e CPF...");

            var queryDoctos18 = (from lstDoctos in dc.ControleDeDocumentos
                                where lstDoctos.DocRGECPF.Contains("SUPPLY CHAIN")
                                 select new { CampoID = lstDoctos.ID, CampoLink = lstDoctos.DocRGECPF });

            if (queryDoctos18.Count() > 0)
            {
                Console.WriteLine("{0} registros encontrados.", queryDoctos18.Count());
                Console.WriteLine("\n");
                Console.WriteLine("Processando Doc. RG e CPF...");

                edititem = null;
                vCount = 0;

                foreach (var itemDocto in queryDoctos18)
                {
                    edititem = dc.ControleDeDocumentos
                                .Where(i => i.ID == itemDocto.CampoID)
                                .FirstOrDefault();

                    edititem.DocRGECPF = itemDocto.CampoLink.Replace(vLinkAntigo, vLinkNovo);

                    dc.UpdateObject(edititem);
                    dc.SaveChanges();

                    vCount = vCount + 1;
                }
                Console.WriteLine("{0} registros atualizados!", vCount);
            }
            else
            {
                Console.WriteLine("Nenhum registro encontrado!");
            }

            Console.WriteLine("\n");
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("\n");


            //===== Atualizando  campo Doc. Adendo de Nível de Serviço
            Console.WriteLine("Verificando Doc. Adendo de Nível de Serviço...");

            var queryDoctos19 = (from lstDoctos in dc.ControleDeDocumentos
                                where lstDoctos.DocAdendoDeNívelDeServiço.Contains("SUPPLY CHAIN")
                                 select new { CampoID = lstDoctos.ID, CampoLink = lstDoctos.DocAdendoDeNívelDeServiço });

            if (queryDoctos19.Count() > 0)
            {
                Console.WriteLine("{0} registros encontrados.", queryDoctos19.Count());
                Console.WriteLine("\n");
                Console.WriteLine("Processando Doc. Adendo de Nível de Serviço...");

                edititem = null;
                vCount = 0;

                foreach (var itemDocto in queryDoctos19)
                {
                    edititem = dc.ControleDeDocumentos
                                .Where(i => i.ID == itemDocto.CampoID)
                                .FirstOrDefault();

                    edititem.DocAdendoDeNívelDeServiço = itemDocto.CampoLink.Replace(vLinkAntigo, vLinkNovo);

                    dc.UpdateObject(edititem);
                    dc.SaveChanges();

                    vCount = vCount + 1;
                }
                Console.WriteLine("{0} registros atualizados!", vCount);
            }
            else
            {
                Console.WriteLine("Nenhum registro encontrado!");
            }

            Console.WriteLine("\n");
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("\n");


            //===== Atualizando  campo Doc. Adendo de Devolução Reversa
            Console.WriteLine("Verificando Doc. Adendo de Devolução Reversa...");

            var queryDoctos20 = (from lstDoctos in dc.ControleDeDocumentos
                                where lstDoctos.DocAdendoDeDevoluçãoReversa.Contains("SUPPLY CHAIN")
                                 select new { CampoID = lstDoctos.ID, CampoLink = lstDoctos.DocAdendoDeDevoluçãoReversa });

            if (queryDoctos20.Count() > 0)
            {
                Console.WriteLine("{0} registros encontrados.", queryDoctos20.Count());
                Console.WriteLine("\n");
                Console.WriteLine("Processando Doc. Adendo de Devolução Reversa...");

                edititem = null;
                vCount = 0;

                foreach (var itemDocto in queryDoctos20)
                {
                    edititem = dc.ControleDeDocumentos
                                .Where(i => i.ID == itemDocto.CampoID)
                                .FirstOrDefault();

                    edititem.DocAdendoDeDevoluçãoReversa = itemDocto.CampoLink.Replace(vLinkAntigo, vLinkNovo);

                    dc.UpdateObject(edititem);
                    dc.SaveChanges();

                    vCount = vCount + 1;
                }
                Console.WriteLine("{0} registros atualizados!", vCount);
            }
            else
            {
                Console.WriteLine("Nenhum registro encontrado!");
            }

            Console.WriteLine("\n");
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("\n");


            //===== Atualizando  campo Doc. Adendo de VPC Reversa
            Console.WriteLine("Verificando Doc. Adendo de VPC Reversa...");

            var queryDoctos21 = (from lstDoctos in dc.ControleDeDocumentos
                                where lstDoctos.DocAdendoDeVPCReversa.Contains("SUPPLY CHAIN")
                                 select new { CampoID = lstDoctos.ID, CampoLink = lstDoctos.DocAdendoDeVPCReversa });

            if (queryDoctos21.Count() > 0)
            {
                Console.WriteLine("{0} registros encontrados.", queryDoctos21.Count());
                Console.WriteLine("\n");
                Console.WriteLine("Processando Doc. Adendo de VPC Reversa...");

                edititem = null;
                vCount = 0;

                foreach (var itemDocto in queryDoctos21)
                {
                    edititem = dc.ControleDeDocumentos
                                .Where(i => i.ID == itemDocto.CampoID)
                                .FirstOrDefault();

                    edititem.DocAdendoDeVPCReversa = itemDocto.CampoLink.Replace(vLinkAntigo, vLinkNovo);

                    dc.UpdateObject(edititem);
                    dc.SaveChanges();

                    vCount = vCount + 1;
                }
                Console.WriteLine("{0} registros atualizados!", vCount);
            }
            else
            {
                Console.WriteLine("Nenhum registro encontrado!");
            }

            Console.WriteLine("\n");
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("\n");


            //===== Atualizando  campo Doc. Adendo de VPC Extra
            Console.WriteLine("Verificando Doc. Adendo de VPC Extra...");

            var queryDoctos22 = (from lstDoctos in dc.ControleDeDocumentos
                                where lstDoctos.DocAdendoDeVPCExtra.Contains("SUPPLY CHAIN")
                                 select new { CampoID = lstDoctos.ID, CampoLink = lstDoctos.DocAdendoDeVPCExtra });

            if (queryDoctos22.Count() > 0)
            {
                Console.WriteLine("{0} registros encontrados.", queryDoctos22.Count());
                Console.WriteLine("\n");
                Console.WriteLine("Processando Doc. Adendo de VPC Extra...");

                edititem = null;
                vCount = 0;

                foreach (var itemDocto in queryDoctos22)
                {
                    edititem = dc.ControleDeDocumentos
                                .Where(i => i.ID == itemDocto.CampoID)
                                .FirstOrDefault();

                    edititem.DocAdendoDeVPCExtra = itemDocto.CampoLink.Replace(vLinkAntigo, vLinkNovo);

                    dc.UpdateObject(edititem);
                    dc.SaveChanges();

                    vCount = vCount + 1;
                }
                Console.WriteLine("{0} registros atualizados!", vCount);
            }
            else
            {
                Console.WriteLine("Nenhum registro encontrado!");
            }

            Console.WriteLine("\n");
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("\n");


            //===== Atualizando  campo Doc. Adendo de Assistência Técnica
            Console.WriteLine("Verificando Doc. Adendo de Assistência Técnica...");

            var queryDoctos23 = (from lstDoctos in dc.ControleDeDocumentos
                                where lstDoctos.DocAdendoDeAssistênciaTécnica.Contains("SUPPLY CHAIN")
                                 select new { CampoID = lstDoctos.ID, CampoLink = lstDoctos.DocAdendoDeAssistênciaTécnica });

            if (queryDoctos23.Count() > 0)
            {
                Console.WriteLine("{0} registros encontrados.", queryDoctos23.Count());
                Console.WriteLine("\n");
                Console.WriteLine("Processando Doc. Adendo de Assistência Técnica...");

                edititem = null;
                vCount = 0;

                foreach (var itemDocto in queryDoctos23)
                {
                    edititem = dc.ControleDeDocumentos
                                .Where(i => i.ID == itemDocto.CampoID)
                                .FirstOrDefault();

                    edititem.DocAdendoDeAssistênciaTécnica = itemDocto.CampoLink.Replace(vLinkAntigo, vLinkNovo);

                    dc.UpdateObject(edititem);
                    dc.SaveChanges();

                    vCount = vCount + 1;
                }
                Console.WriteLine("{0} registros atualizados!", vCount);
            }
            else
            {
                Console.WriteLine("Nenhum registro encontrado!");
            }

            Console.WriteLine("\n");
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("\n");


            //===== Atualizando  campo Doc. Adendo de Fluxo de Processos Judiciais
            Console.WriteLine("Verificando Doc. Adendo de Fluxo de Processos Judiciais...");

            var queryDoctos24 = (from lstDoctos in dc.ControleDeDocumentos
                                where lstDoctos.DocAdendoDeFluxoDeProcessosJudiciais.Contains("SUPPLY CHAIN")
                                 select new { CampoID = lstDoctos.ID, CampoLink = lstDoctos.DocAdendoDeFluxoDeProcessosJudiciais });

            if (queryDoctos24.Count() > 0)
            {
                Console.WriteLine("{0} registros encontrados.", queryDoctos24.Count());
                Console.WriteLine("\n");
                Console.WriteLine("Processando Doc. Adendo de Fluxo de Processos Judiciais...");

                edititem = null;
                vCount = 0;

                foreach (var itemDocto in queryDoctos24)
                {
                    edititem = dc.ControleDeDocumentos
                                .Where(i => i.ID == itemDocto.CampoID)
                                .FirstOrDefault();

                    edititem.DocAdendoDeFluxoDeProcessosJudiciais = itemDocto.CampoLink.Replace(vLinkAntigo, vLinkNovo);

                    dc.UpdateObject(edititem);
                    dc.SaveChanges();

                    vCount = vCount + 1;
                }
                Console.WriteLine("{0} registros atualizados!", vCount);
            }
            else
            {
                Console.WriteLine("Nenhum registro encontrado!");
            }

            Console.WriteLine("\n");
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("\n");


            //===== Atualizando  campo Doc. Operação
            Console.WriteLine("Verificando Doc. Operação...");

            var queryDoctos25 = (from lstDoctos in dc.ControleDeDocumentos
                                where lstDoctos.DocOperação.Contains("SUPPLY CHAIN")
                                 select new { CampoID = lstDoctos.ID, CampoLink = lstDoctos.DocOperação });

            if (queryDoctos25.Count() > 0)
            {
                Console.WriteLine("{0} registros encontrados.", queryDoctos25.Count());
                Console.WriteLine("\n");
                Console.WriteLine("Processando Doc. Operação...");

                edititem = null;
                vCount = 0;

                foreach (var itemDocto in queryDoctos25)
                {
                    edititem = dc.ControleDeDocumentos
                                .Where(i => i.ID == itemDocto.CampoID)
                                .FirstOrDefault();

                    edititem.DocOperação = itemDocto.CampoLink.Replace(vLinkAntigo, vLinkNovo);

                    dc.UpdateObject(edititem);
                    dc.SaveChanges();

                    vCount = vCount + 1;
                }
                Console.WriteLine("{0} registros atualizados!", vCount);
            }
            else
            {
                Console.WriteLine("Nenhum registro encontrado!");
            }

            Console.WriteLine("\n");
            Console.WriteLine("FIM");
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("\n");


            Console.ReadLine();
        }
    } 
}

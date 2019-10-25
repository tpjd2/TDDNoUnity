using System;
using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using UnityEngine.UI;

namespace Tests
{
    public class ContainerTestes
    {
        public class TestesMetodoRecarga
        {
            Image alvo;
            Coracao corAlvo;
            Container container;

            [SetUp]
            public void Config()
            {
                alvo = new GameObject().AddComponent<Image>();
            }

            [Test]
            public void ContainerPreenchimento0Recarga0()
            {
                alvo.fillAmount = 0.0f;
                corAlvo = new Coracao(alvo);
                
                container = new Container(new List<Coracao> { corAlvo });

                container.Recarregar(0);

                Assert.AreEqual(0, alvo.fillAmount);
            }

            [Test]
            public void ContainerPreenchimento0Recarga1()
            {
                alvo.fillAmount = 0.0f;
                corAlvo = new Coracao(alvo);

                container = new Container(new List<Coracao> { corAlvo });

                container.Recarregar(1);

                Assert.AreEqual(0.25f, alvo.fillAmount);
            }

            [Test]
            public void ContainerPreenchimento1Recarga1()
            {
                alvo.fillAmount = 0.0f;
                corAlvo = new Coracao(alvo);

                Image imgAux = new GameObject().AddComponent<Image>();
                imgAux.fillAmount = 1.0f;
                Coracao corAux = new Coracao(imgAux);

                container = new Container(new List<Coracao> { corAux, corAlvo});

                container.Recarregar(1);
                Assert.AreEqual(0.25f, alvo.fillAmount);
            }

            [Test]
            public void Container2CoracoesPreenchimento0Recarga1()
            {
                alvo.fillAmount = 0.0f;
                corAlvo = new Coracao(alvo);

                Image imgAux = new GameObject().AddComponent<Image>();
                imgAux.fillAmount = 0.0f;
                Coracao corAux = new Coracao(imgAux);

                container = new Container(new List<Coracao> { corAux, corAlvo});

                container.Recarregar(1);
                Assert.AreEqual(0.0f, alvo.fillAmount);
            }
        }

        public class TestesMetodoDescarga
        {

        }
    }

    public class Container
    {
        private List<Coracao> list;

        public Container(List<Coracao> list)
        {
            this.list = list;
        }

        public void Recarregar(int pedacos)
        {
            int recarregar = pedacos;
            foreach (Coracao temp in list)
            {
                if (recarregar > 0 && temp.getPedacos() < 4)
                {
                    temp.Recarregar(pedacos);
                    recarregar -= 1;
                }
            }
        }
    }
}

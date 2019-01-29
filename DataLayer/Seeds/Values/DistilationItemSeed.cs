﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Havit.Data.Patterns.DataSeeds;
using Havit.Distiller.Model;

namespace Havit.Distiller.DataLayer.Seeds.Values
{
	public class DistilationItemSeed : DataSeed<ValuesProfile>
	{
		public override void SeedData()
		{
			var data = new[]
			{
				new DistillationItem() { Text = "Acceptance – Přijetí" },
				new DistillationItem() { Text = "Accessibility - Přístupnost" },
				new DistillationItem() { Text = "Accomplishment – Dosažení, splnění" },
				new DistillationItem() { Text = "Accountability – Odpovědnost" },
				new DistillationItem() { Text = "Accuracy – Přesnost" },
				new DistillationItem() { Text = "Achievement  - Úspěch" },
				new DistillationItem() { Text = "Activeness – Aktivnost" },
				new DistillationItem() { Text = "Adaptability – Přizpůsobivost" },
				new DistillationItem() { Text = "Adventure – Dobrodružnost" },
				new DistillationItem() { Text = "Aesthetics – Estetika" },
				new DistillationItem() { Text = "Agility – Agilita, hbitost" },
				new DistillationItem() { Text = "Alertness – Ostražitost" },
				new DistillationItem() { Text = "Ambition – Ctižádost" },
				new DistillationItem() { Text = "Appreciation – Uznání" },
				new DistillationItem() { Text = "Approachability - Přístupnost" },
				new DistillationItem() { Text = "Assertiveness - Asertivita" },
				new DistillationItem() { Text = "Attentiveness - Pozornost" },
				new DistillationItem() { Text = "Availability - Dostupnost" },
				new DistillationItem() { Text = "Awareness - Povědomí" },
				new DistillationItem() { Text = "Balance - Rovnováha" },
				new DistillationItem() { Text = "Beauty - Krása" },
				new DistillationItem() { Text = "Benevolence - Shovívavost" },
				new DistillationItem() { Text = "Boldness - Odvaha" },
				new DistillationItem() { Text = "Bravery - Udatnost" },
				new DistillationItem() { Text = "Brilliance – Brilance, oslnivost" },
				new DistillationItem() { Text = "Calmness – Klidnost" },
				new DistillationItem() { Text = "Camaraderie - Kamarádství" },
				new DistillationItem() { Text = "Candor - Upřímnost" },
				new DistillationItem() { Text = "Capability - Schopnost" },
				new DistillationItem() { Text = "Carefulness - Pečlivost" },
				new DistillationItem() { Text = "Caution - Opatrnost" },
				new DistillationItem() { Text = "Change - Změna" },
				new DistillationItem() { Text = "Charity - Charita" },
				new DistillationItem() { Text = "Cheerfulness – Veselí" },
				new DistillationItem() { Text = "Clarity - Jasnost" },
				new DistillationItem() { Text = "Cleanliness - Čistota" },
				new DistillationItem() { Text = "Cleverness - Chytrost" },
				new DistillationItem() { Text = "Collaboration - Spolupráce" },
				new DistillationItem() { Text = "Commitment – Angažovanost" },
				new DistillationItem() { Text = "Compassion - Soucit" },
				new DistillationItem() { Text = "Competence – Kompetentnost" },
				new DistillationItem() { Text = "Concentration – Koncentrace, soustředění" },
				new DistillationItem() { Text = "Confidence - Sebejistota" },
				new DistillationItem() { Text = "Conformity - Konformita" },
				new DistillationItem() { Text = "Consistency - Konzistence" },
				new DistillationItem() { Text = "Contentment - Spokojenost" },
				new DistillationItem() { Text = "Cooperation - Spolupráce" },
				new DistillationItem() { Text = "Courage – Kuráž, odvaha" },
				new DistillationItem() { Text = "Courtesy - Zdvořilost" },
				new DistillationItem() { Text = "Craftiness – Lstivost? Řemeslnost?" },
				new DistillationItem() { Text = "Creativity – Kreativita, tvořivost" },
				new DistillationItem() { Text = "Credibility – Hodnověrnost" },
				new DistillationItem() { Text = "Cunning - Mazanost" },
				new DistillationItem() { Text = "Curiosity - Zvědavost" },
				new DistillationItem() { Text = "Daring - Odvaha" },
				new DistillationItem() { Text = "Decisiveness - Rozhodnost" },
				new DistillationItem() { Text = "Dedication - Obětavost" },
				new DistillationItem() { Text = "Dependability - Spolehlivost" },
				new DistillationItem() { Text = "Determination - Odhodlání" },
				new DistillationItem() { Text = "Devotion - Oddanost" },
				new DistillationItem() { Text = "Dignity - Důstojnost" },
				new DistillationItem() { Text = "Diligence – Píle, pracovitost" },
				new DistillationItem() { Text = "Directness - Přímočarost" },
				new DistillationItem() { Text = "Discipline - Disciplína" },
				new DistillationItem() { Text = "Discovery - Objevnost" },
				new DistillationItem() { Text = "Discretion - Diskrétnost" },
				new DistillationItem() { Text = "Diversity - Rozmanitost" },
				new DistillationItem() { Text = "Drive – Úsilí, tah na bránu" },
				new DistillationItem() { Text = "Duty - Povinnost" },
				new DistillationItem() { Text = "Dynamism - Dynamika" },
				new DistillationItem() { Text = "Eagerness – Dychtivost, horlivost" },
				new DistillationItem() { Text = "Education - Vzdělání" },
				new DistillationItem() { Text = "Effectiveness – Účinnost (správné věci)" },
				new DistillationItem() { Text = "Efficiency – Účinnost (věci správně)" },
				new DistillationItem() { Text = "Elegance - Elegance" },
				new DistillationItem() { Text = "Empathy - Empatie" },
				new DistillationItem() { Text = "Encouragement - Povzbuzení" },
				new DistillationItem() { Text = "Endurance - Vytrvalost" },
				new DistillationItem() { Text = "Energy - Energie" },
				new DistillationItem() { Text = "Enjoyment – Zážitek, požitek, potěšení" },
				new DistillationItem() { Text = "Entertainment - Zábava" },
				new DistillationItem() { Text = "Enthusiasm – Nadšení" },
				new DistillationItem() { Text = "Equality - Rovnost" },
				new DistillationItem() { Text = "Excellence - Dokonalost" },
				new DistillationItem() { Text = "Excitement - Vzrušení" },
				new DistillationItem() { Text = "Experience - Zkušenost" },
				new DistillationItem() { Text = "Expertise - Odbornost" },
				new DistillationItem() { Text = "Exploration – Objevování, průzkum" },
				new DistillationItem() { Text = "Expressiveness - Výraznost" },
				new DistillationItem() { Text = "Extroversion - Extroverze" },
				new DistillationItem() { Text = "Exuberance - Hojnost" },
				new DistillationItem() { Text = "Fairness - Férovost" },
				new DistillationItem() { Text = "Faith – Víra, důvěra" },
				new DistillationItem() { Text = "Faithfulness – Věrnost, loajálnost" },
				new DistillationItem() { Text = "Family - Rodina" },
				new DistillationItem() { Text = "Fearlessness - Nebojácnost" },
				new DistillationItem() { Text = "Ferocity – Divokost, dravost" },
				new DistillationItem() { Text = "Fidelity - Věrnost" },
				new DistillationItem() { Text = "Fierceness – Divokost, prudkost" },
				new DistillationItem() { Text = "Fitness – Zdatnost, kondice" },
				new DistillationItem() { Text = "Flexibility – Flexibilita, pružnost" },
				new DistillationItem() { Text = "Fluency - Plynulost" },
				new DistillationItem() { Text = "Focus – Soustředění, zaměření" },
				new DistillationItem() { Text = "Frankness - Upřímnost" },
				new DistillationItem() { Text = "Freedom  - Svoboda" },
				new DistillationItem() { Text = "Friendliness – Přátelskost, přívětivost" },
				new DistillationItem() { Text = "Friendship - Přátelství" },
				new DistillationItem() { Text = "Fun – Zábava, legrace" },
				new DistillationItem() { Text = "Generosity – Štědrost, šlechetnost" },
				new DistillationItem() { Text = "Gratitude - Vděčnost" },
				new DistillationItem() { Text = "Growth - Růst" },
				new DistillationItem() { Text = "Happiness – Štěstí, spokojenost" },
				new DistillationItem() { Text = "Harmony - Harmonie" },
				new DistillationItem() { Text = "Health - Zdraví" },
				new DistillationItem() { Text = "Helpfulness - Prospěšnost" },
				new DistillationItem() { Text = "Heroism - Hrdinství" },
				new DistillationItem() { Text = "Honesty – Poctivost, čestnost" },
				new DistillationItem() { Text = "Honor – Čest, pocta" },
				new DistillationItem() { Text = "Hopefulness - Nadějnost" },
				new DistillationItem() { Text = "Hospitality - Pohostinnost" },
				new DistillationItem() { Text = "Humility – Pokora, skromnost" },
				new DistillationItem() { Text = "Humor" },
				new DistillationItem() { Text = "Imagination - Představivost" },
				new DistillationItem() { Text = "Impartiality - Nestrannost" },
				new DistillationItem() { Text = "Independence – Nezávislost, samostatnost" },
				new DistillationItem() { Text = "Ingenuity - Vynalézavost" },
				new DistillationItem() { Text = "Initiative - Iniciativa" },
				new DistillationItem() { Text = "Innovation – Inovace, novátoství" },
				new DistillationItem() { Text = "Inquisitiveness - Nezvyklost" },
				new DistillationItem() { Text = "Insightfulness - Náskok" },
				new DistillationItem() { Text = "Inspiration - Inspirace" },
				new DistillationItem() { Text = "Integrity – Integrita, bezúhonnost" },
				new DistillationItem() { Text = "Intelligence - Inteligence" },
				new DistillationItem() { Text = "Introversion - Introverství" },
				new DistillationItem() { Text = "Intuitiveness - Intuitivnost" },
				new DistillationItem() { Text = "Inventiveness - Vynalézavost" },
				new DistillationItem() { Text = "Joy – Radost, potěšení" },
				new DistillationItem() { Text = "Justice - Spravedlnost" },
				new DistillationItem() { Text = "Kindness - Laskavost" },
				new DistillationItem() { Text = "Knowledge – Znalosti, vědomosti" },
				new DistillationItem() { Text = "Leadership - Vůdcovství" },
				new DistillationItem() { Text = "Learning – Učení se" },
				new DistillationItem() { Text = "Liberty - Svoboda" },
				new DistillationItem() { Text = "Logic – Logika, Logičnost" },
				new DistillationItem() { Text = "Love - Láska" },
				new DistillationItem() { Text = "Loyalty – Věrnost, lajalita" },
				new DistillationItem() { Text = "Mastery - Mistrovství" },
				new DistillationItem() { Text = "Maturity – Zralost, dospělost" },
				new DistillationItem() { Text = "Meticulousness - Pečlivost" },
				new DistillationItem() { Text = "Mindfulness – Vědomost?" },
				new DistillationItem() { Text = "Modesty - Skromnost" },
				new DistillationItem() { Text = "Motivation - Motivace" },
				new DistillationItem() { Text = "Neatness – Elegance, uklizenost" },
				new DistillationItem() { Text = "Open-mindedness – Otevřenost (o. mysl)" },
				new DistillationItem() { Text = "Openness - Otevřenost" },
				new DistillationItem() { Text = "Optimism – Optimizmus" },
				new DistillationItem() { Text = "Order - Pořádek" },
				new DistillationItem() { Text = "Orderliness - Uspořádanost" },
				new DistillationItem() { Text = "Organization – Organizace" },
				new DistillationItem() { Text = "Originality - Originalita" },
				new DistillationItem() { Text = "Outlandishness – Cizozemství?" },
				new DistillationItem() { Text = "Outrageousness – Rozhořčení, rozhořčenost" },
				new DistillationItem() { Text = "Passion - Vášeň" },
				new DistillationItem() { Text = "Patience - Trpělivost" },
				new DistillationItem() { Text = "Peace – Mír, klid" },
				new DistillationItem() { Text = "Perceptiveness - Vnímavost" },
				new DistillationItem() { Text = "Perfection - Dokonalost" },
				new DistillationItem() { Text = "Perseverance – Vytrvalost, úpornost" },
				new DistillationItem() { Text = "Persistence – Vytrvalost" },
				new DistillationItem() { Text = "Persuasiveness - Přesvědčivost" },
				new DistillationItem() { Text = "Philanthropy – Dobročinnost, filantropie" },
				new DistillationItem() { Text = "Playfulness - Hravost" },
				new DistillationItem() { Text = "Pleasure – Potěšení, radost, rozkoš" },
				new DistillationItem() { Text = "Power – Moc, síla" },
				new DistillationItem() { Text = "Pragmatism – Pragmatizmus, účelnost" },
				new DistillationItem() { Text = "Precision - Přesnost" },
				new DistillationItem() { Text = "Preparedness - Připravenost" },
				new DistillationItem() { Text = "Privacy – Soukromí, důvěrnost" },
				new DistillationItem() { Text = "Proactivity - Proaktivita" },
				new DistillationItem() { Text = "Professionalism - Profesionalizmus" },
				new DistillationItem() { Text = "Prudence – Opatrnost, obezřetnost" },
				new DistillationItem() { Text = "Punctuality – Dochvilnost, přesnost" },
				new DistillationItem() { Text = "Purposefulness - Účelnost" },
				new DistillationItem() { Text = "Rationality – Racionálnost, rozumnost" },
				new DistillationItem() { Text = "Realism - Realizmus" },
				new DistillationItem() { Text = "Reason – Důvod, příčina, smysl" },
				new DistillationItem() { Text = "Reflection – Reflexe" },
				new DistillationItem() { Text = "Regularity - Pravidelnost" },
				new DistillationItem() { Text = "Reliability - Spolehlivost" },
				new DistillationItem() { Text = "Resilience – Odolnost, pružnost" },
				new DistillationItem() { Text = "Resolution – Rozhodnost, odhodlanost" },
				new DistillationItem() { Text = "Resolve - Odhodlání" },
				new DistillationItem() { Text = "Resourcefulness - Vynalézavost" },
				new DistillationItem() { Text = "Respect – Respekt, úcta" },
				new DistillationItem() { Text = "Responsibility – Odpovědnost" },
				new DistillationItem() { Text = "Responsiveness – Responsivnost (rychlá odezva)" },
				new DistillationItem() { Text = "Restraint - Zdženlivost" },
				new DistillationItem() { Text = "Rigor - Přísnosts" },
				new DistillationItem() { Text = "Sacrifice - Obětování" },
				new DistillationItem() { Text = "Security – Zabezpečení, bezpečnost" },
				new DistillationItem() { Text = "Self-control – Sebe-ovládání" },
				new DistillationItem() { Text = "Self-discipline – Sebe-disciplína" },
				new DistillationItem() { Text = "Self-reliance - Samostatnost" },
				new DistillationItem() { Text = "Sensitivity - Citlivost" },
				new DistillationItem() { Text = "Serenity – Vyrovnanost, klid" },
				new DistillationItem() { Text = "Service - Služba" },
				new DistillationItem() { Text = "Sharing - Sdílení" },
				new DistillationItem() { Text = "Silliness – Hloupost, pošetilost" },
				new DistillationItem() { Text = "Simplicity - Jednoduchost" },
				new DistillationItem() { Text = "Sincerity – Upřímnost, opravdovost" },
				new DistillationItem() { Text = "Skill – Dovednost, zručnost, schopnost" },
				new DistillationItem() { Text = "Solidarity – Solidarita, sounáležitost" },
				new DistillationItem() { Text = "Speed - Rychlost" },
				new DistillationItem() { Text = "Spirituality - Duchovno" },
				new DistillationItem() { Text = "Spontaneity – Spontánost, nenucenost" },
				new DistillationItem() { Text = "Stability – Stabilita, stálost" },
				new DistillationItem() { Text = "Status – Postavení, prestiž" },
				new DistillationItem() { Text = "Stealth - Tajnost" },
				new DistillationItem() { Text = "Stewardship - Správcovství" },
				new DistillationItem() { Text = "Strength - Síla" },
				new DistillationItem() { Text = "Success - Úspěch" },
				new DistillationItem() { Text = "Support - Podpora" },
				new DistillationItem() { Text = "Sympathy - Sympatie" },
				new DistillationItem() { Text = "Synergy - Synergie" },
				new DistillationItem() { Text = "Teamwork – Týmová práce" },
				new DistillationItem() { Text = "Thankfulness - Vděčnost" },
				new DistillationItem() { Text = "Thoroughness – Pečlivost, důkladnost" },
				new DistillationItem() { Text = "Thoughtfulness - Ohleduplnost" },
				new DistillationItem() { Text = "Thrift – Šetrnost, hospodárnost" },
				new DistillationItem() { Text = "Timeliness - Včasnost" },
				new DistillationItem() { Text = "Tolerance - Snášenlivost" },
				new DistillationItem() { Text = "Tranquility – Klid, pokoj" },
				new DistillationItem() { Text = "Transcendence - Dokonalost" },
				new DistillationItem() { Text = "Trust - Důvěra" },
				new DistillationItem() { Text = "Trustworthiness - Důvěryhodnost" },
				new DistillationItem() { Text = "Truth – Pravda, pravdivost" },
				new DistillationItem() { Text = "Understanding – Porozumění, pochopení" },
				new DistillationItem() { Text = "Uniqueness - Jedinečnost" },
				new DistillationItem() { Text = "Unity - Jednota" },
				new DistillationItem() { Text = "Valor – Chrabrost, udatnost" },
				new DistillationItem() { Text = "Variety - Rozmanitost" },
				new DistillationItem() { Text = "Vigor – Ráznost, důraznost" },
				new DistillationItem() { Text = "Vision – Vize, prozíravost" },
				new DistillationItem() { Text = "Vitality - Vitalita" },
				new DistillationItem() { Text = "Warmth – Vřelost, srdečnost" },
				new DistillationItem() { Text = "Willfulness - Úmyslnost" },
				new DistillationItem() { Text = "Wisdom - Moudrost" },
				new DistillationItem() { Text = "Wittiness - Vtipnost" },
				new DistillationItem() { Text = "Wonder – Chtít vědět" },
				new DistillationItem() { Text = "Zeal - Horlivost" },
			};

			Seed(For(data).PairBy(i => i.Text));
		}
	}
}

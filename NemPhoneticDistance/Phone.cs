using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NemPhoneticDistance {
  internal class Phone {
    public Feature Cons { get; set; } = new Feature() { Name = "cons" };
    public Feature Son { get; set; } = new Feature() { Name = "son" };
    public Feature Syll { get; set; } = new Feature() { Name = "syll" };

    public Feature Labial { get; set; } = new Feature() { Name = "labial" };
    public Feature Round { get; set; } = new Feature() { Name = "round" };

    public Feature Coronal { get; set; } = new Feature() { Name = "coronal" };
    public Feature Ant { get; set; } = new Feature() { Name = "ant" };
    public Feature Dist { get; set; } = new Feature() { Name = "dist" };

    public Feature Dorsal { get; set; } = new Feature() { Name = "dorsal" };
    public Feature High { get; set; } = new Feature() { Name = "high" };
    public Feature Low { get; set; } = new Feature() { Name = "low" };
    public Feature Back { get; set; } = new Feature() { Name = "back" };
    public Feature Tense { get; set; } = new Feature() { Name = "tense" };

    public Feature Pharyngeal { get; set; } = new Feature() { Name = "pharyngeal" };
    public Feature ATR { get; set; } = new Feature() { Name = "atr" };

    public Feature Voice { get; set; } = new Feature() { Name = "voice" };
    public Feature SG { get; set; } = new Feature() { Name = "sg" };
    public Feature CG { get; set; } = new Feature() { Name = "cg" };

    public Feature Cont { get; set; } = new Feature() { Name = "cont" };
    public Feature Strident { get; set; } = new Feature() { Name = "strident" };
    public Feature Lateral { get; set; } = new Feature() { Name = "lateral" };
    public Feature DelRel { get; set; } = new Feature() { Name = "del rel" };
    public Feature Nasal { get; set; } = new Feature() { Name = "nasal" };
  }
}

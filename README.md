# MarcusMedina.Fluent.TypedMath

[![NuGet](https://img.shields.io/nuget/v/MarcusMedina.Fluent.TypedMath.svg?style=for-the-badge&logo=nuget)](https://www.nuget.org/packages/MarcusMedina.Fluent.TypedMath/)
[![NuGet Downloads](https://img.shields.io/nuget/dt/MarcusMedina.Fluent.TypedMath.svg?style=for-the-badge&logo=nuget)](https://www.nuget.org/packages/MarcusMedina.Fluent.TypedMath/)
[![C#](https://img.shields.io/badge/C%23-14.0-239120?style=for-the-badge&logo=csharp&logoColor=white)](#)
[![.NET](https://img.shields.io/badge/.NET-10.0+-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)](https://dotnet.microsoft.com/)
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg?style=for-the-badge)](https://opensource.org/licenses/MIT)
![Open Source](https://raw.githubusercontent.com/MarcusMedinaPro/MarcusMedina.Fluent.TypedMath/main/assets/open-source.svg)
[![Build](https://img.shields.io/github/actions/workflow/status/MarcusMedinaPro/MarcusMedina.Fluent.TypedMath/release.yml?branch=main&label=Build&style=for-the-badge&logo=github)](https://github.com/MarcusMedinaPro/MarcusMedina.Fluent.TypedMath/actions)
[![Signed](https://img.shields.io/badge/Signed-Sigstore-green?style=for-the-badge&logo=linux)](https://docs.sigstore.dev)



**Type-safe mathematical operations in C# with compile-time guarantees**

> This one comes from 2011, a period when a lot of things in my life — work and home — were going wrong at once. I noticed letters and numbers had started swapping places or seeming to dance on the line, and realised the stress had brought on a mild touch of what's usually called dyslexia. That got me thinking about what it's like for people who deal with that regularly — I researched bionic reading, and stumbled onto dyscalculia along the way. So I decided to turn maths, which I love, into more of a text-based, step-by-step form, to take the pressure off writing long calculations crammed onto a single line. I remembered doing electrical drawings from code once — working out placements on an A4 page — and how breaking those calculations into named, reusable methods, instead of cramming them into one spot, was what made that kind of coding possible again when the stress had made it genuinely hard. The stress eventually settled, and after a few years I was back to programming as usual — but this library is what came out of that stretch.
>
> In this case, I wanted every calculation to be able to stand on its own line, named and reusable, rather than buried inside a longer expression.

Build mathematical expressions with strong typing to prevent unit mismatches and ensure correctness at compile time.

---

## 🚀 Quick Start

```bash
dotnet add package MarcusMedina.Fluent.TypedMath
```

**Requirements:**
- .NET 10.0 or later
- C# 14.0 or later

---

## 📖 Documentation

- [Getting Started Guide](https://github.com/MarcusMedinaPro/MarcusMedina.Fluent.TypedMath/blob/main/csharp/Manual/GettingStarted.md)
- [Complete Manual](https://github.com/MarcusMedinaPro/MarcusMedina.Fluent.TypedMath/blob/main/csharp/Manual/README.md)
- [API Reference](https://github.com/MarcusMedinaPro/MarcusMedina.Fluent.TypedMath/blob/main/csharp/Manual/API.md)

---

## 📄 License

MIT License - See [LICENSE](https://github.com/MarcusMedinaPro/MarcusMedina.Fluent.TypedMath/blob/main/LICENSE) file for details.

**Version:** 0.2.0 | **Updated:** 2025-03-16

## Package integrity

All releases are signed with [cosign](https://docs.sigstore.dev) (Sigstore keyless signing).

To verify a downloaded package, download both the `.nupkg` and its `.sigstore.json` bundle from the [GitHub Release](../https://github.com/MarcusMedinaPro/MarcusMedina.Fluent.TypedMath/releases), then run:

```bash
cosign verify-blob <package.nupkg> \
  --bundle <package.nupkg.sigstore.json> \
  --certificate-identity-regexp "https://github.com/MarcusMedinaPro/.*/release.yml" \
  --certificate-oidc-issuer https://token.actions.githubusercontent.com
```

Expected output: `Verified OK`


## Built with Human + AI Collaboration

This library was written by **Marcus Medina** together with **Claude Code** (Anthropic) — not through "vibe coding" where you just describe and accept, but through genuine collaboration: planning together, reviewing each other's decisions, pushing back when something felt wrong, and iterating until the result felt right.

The goal was always to write code worth reading — the kind a student can open, understand, and learn from. AI was a partner in that process, not a shortcut around it.

If you're curious about this way of working, the source code and git history are open. Every decision has a reason behind it.

## Made for Curious Minds

This library was built with students in mind — not as a black box to copy and paste, but as a real-world example of how clean, purposeful code is written and shared.

Whether you're discovering C# for the first time, need a reliable helper for your school project, or are simply trying to fall in love with writing code — you're exactly who this was made for.

The source is open. Read it, fork it, break it, improve it. That's the whole point.

And if this library saved you an afternoon, or made something click that didn't before — that's everything.

*Non-students are equally welcome. Good code doesn't care about your diploma.*

⭐ If this helped you, consider starring the project on GitHub — it helps other students find it too.

💬 Have an idea, a feature request, or just want to say hi? Open an issue on GitHub — I'd love to hear from you.

﻿// <autogenerated />
#nullable enable
using System;
using System.Threading.Tasks;
using RpgGenerator.Annotations;

namespace RpgGenerator.Test.DataSource.RpgGeneratorUnitTests.Basic
{
	internal sealed class Phase1Phase
	{
		public int X { get; }
		public int Y { get; }

		public Phase1Phase(int x, int y)
		{
			X = x;
			Y = y;
		}
	}

	internal sealed class Phase2Phase
	{
		private Phase1Phase Context { get; }
		public int X => Context.X;
		public int Y => Context.Y;
		public int Z { get; }

		public Phase2Phase(Phase1Phase context, int z)
		{
			Context = context;
			Z = z;
		}
	}

	internal sealed class BattlePhasesHandler : IBattlePhases
	{
		private readonly IBattlePhasesLogic _logic;

		public BattlePhasesHandler(IBattlePhasesLogic logic)
		{
			_logic = logic;
		}

		public async Task<PhaseResult<string>> Phase1(int x, int y)
		{
			var __phase = new Phase1Phase(x, y);
			return await HandlePhaseFlowAsync(() => _logic.DoPhase1Async(__phase, this));
		}

		public async Task<PhaseResult<string>> Phase2(Phase1Phase context, int z)
		{
			var __phase = new Phase2Phase(context, z);
			return await HandlePhaseFlowAsync(() => _logic.DoPhase2Async(__phase, this));
		}

		private async Task<PhaseResult<TResult>> HandlePhaseFlowAsync<TResult>(Func<Task<PhaseResult<TResult>>> logic)
			where TResult : class
		{
			while (true)
			{
				switch (await logic.Invoke())
				{
				case Cancelled<TResult> cancelled: return new Backed<TResult>();
				case Finished<TResult> finished: return finished;
				}
			}
		}

		private sealed class Backed<T> : PhaseResult<T>
		{
			public override T UnWrapOrDefault() => default;
		}
	}

	internal interface IBattlePhasesLogic
	{
		Task<PhaseResult<string>> DoPhase1Async(Phase1Phase phase, IBattlePhases handler);
		Task<PhaseResult<string>> DoPhase2Async(Phase2Phase phase, IBattlePhases handler);
	}
}

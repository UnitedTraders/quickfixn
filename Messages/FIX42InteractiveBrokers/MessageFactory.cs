// This is a generated file.  Don't edit it directly!

using System.Collections.Generic;
using QuickFix.FixValues;

namespace QuickFix
{
    namespace FIX42InteractiveBrokers
    {
        public class MessageFactory : IMessageFactory
        {
            public ICollection<string> GetSupportedBeginStrings()
            {
				return new [] { BeginString.FIX42 };
            }

			
            public QuickFix.Message Create(string beginString, string msgType)
            {
                switch (msgType)
                {
                    case QuickFix.FIX42InteractiveBrokers.Heartbeat.MsgType: return new QuickFix.FIX42InteractiveBrokers.Heartbeat();
                    case QuickFix.FIX42InteractiveBrokers.Logon.MsgType: return new QuickFix.FIX42InteractiveBrokers.Logon();
                    case QuickFix.FIX42InteractiveBrokers.TestRequest.MsgType: return new QuickFix.FIX42InteractiveBrokers.TestRequest();
                    case QuickFix.FIX42InteractiveBrokers.ResendRequest.MsgType: return new QuickFix.FIX42InteractiveBrokers.ResendRequest();
                    case QuickFix.FIX42InteractiveBrokers.Reject.MsgType: return new QuickFix.FIX42InteractiveBrokers.Reject();
                    case QuickFix.FIX42InteractiveBrokers.SequenceReset.MsgType: return new QuickFix.FIX42InteractiveBrokers.SequenceReset();
                    case QuickFix.FIX42InteractiveBrokers.Logout.MsgType: return new QuickFix.FIX42InteractiveBrokers.Logout();
                    case QuickFix.FIX42InteractiveBrokers.Advertisement.MsgType: return new QuickFix.FIX42InteractiveBrokers.Advertisement();
                    case QuickFix.FIX42InteractiveBrokers.IndicationofInterest.MsgType: return new QuickFix.FIX42InteractiveBrokers.IndicationofInterest();
                    case QuickFix.FIX42InteractiveBrokers.News.MsgType: return new QuickFix.FIX42InteractiveBrokers.News();
                    case QuickFix.FIX42InteractiveBrokers.Email.MsgType: return new QuickFix.FIX42InteractiveBrokers.Email();
                    case QuickFix.FIX42InteractiveBrokers.QuoteRequest.MsgType: return new QuickFix.FIX42InteractiveBrokers.QuoteRequest();
                    case QuickFix.FIX42InteractiveBrokers.Quote.MsgType: return new QuickFix.FIX42InteractiveBrokers.Quote();
                    case QuickFix.FIX42InteractiveBrokers.MassQuote.MsgType: return new QuickFix.FIX42InteractiveBrokers.MassQuote();
                    case QuickFix.FIX42InteractiveBrokers.QuoteCancel.MsgType: return new QuickFix.FIX42InteractiveBrokers.QuoteCancel();
                    case QuickFix.FIX42InteractiveBrokers.QuoteStatusRequest.MsgType: return new QuickFix.FIX42InteractiveBrokers.QuoteStatusRequest();
                    case QuickFix.FIX42InteractiveBrokers.QuoteAcknowledgement.MsgType: return new QuickFix.FIX42InteractiveBrokers.QuoteAcknowledgement();
                    case QuickFix.FIX42InteractiveBrokers.MarketDataRequest.MsgType: return new QuickFix.FIX42InteractiveBrokers.MarketDataRequest();
                    case QuickFix.FIX42InteractiveBrokers.MarketDataSnapshotFullRefresh.MsgType: return new QuickFix.FIX42InteractiveBrokers.MarketDataSnapshotFullRefresh();
                    case QuickFix.FIX42InteractiveBrokers.MarketDataIncrementalRefresh.MsgType: return new QuickFix.FIX42InteractiveBrokers.MarketDataIncrementalRefresh();
                    case QuickFix.FIX42InteractiveBrokers.MarketDataRequestReject.MsgType: return new QuickFix.FIX42InteractiveBrokers.MarketDataRequestReject();
                    case QuickFix.FIX42InteractiveBrokers.SecurityDefinitionRequest.MsgType: return new QuickFix.FIX42InteractiveBrokers.SecurityDefinitionRequest();
                    case QuickFix.FIX42InteractiveBrokers.SecurityDefinition.MsgType: return new QuickFix.FIX42InteractiveBrokers.SecurityDefinition();
                    case QuickFix.FIX42InteractiveBrokers.SecurityStatusRequest.MsgType: return new QuickFix.FIX42InteractiveBrokers.SecurityStatusRequest();
                    case QuickFix.FIX42InteractiveBrokers.SecurityStatus.MsgType: return new QuickFix.FIX42InteractiveBrokers.SecurityStatus();
                    case QuickFix.FIX42InteractiveBrokers.TradingSessionStatusRequest.MsgType: return new QuickFix.FIX42InteractiveBrokers.TradingSessionStatusRequest();
                    case QuickFix.FIX42InteractiveBrokers.TradingSessionStatus.MsgType: return new QuickFix.FIX42InteractiveBrokers.TradingSessionStatus();
                    case QuickFix.FIX42InteractiveBrokers.NewOrderSingle.MsgType: return new QuickFix.FIX42InteractiveBrokers.NewOrderSingle();
                    case QuickFix.FIX42InteractiveBrokers.ExecutionReport.MsgType: return new QuickFix.FIX42InteractiveBrokers.ExecutionReport();
                    case QuickFix.FIX42InteractiveBrokers.DontKnowTrade.MsgType: return new QuickFix.FIX42InteractiveBrokers.DontKnowTrade();
                    case QuickFix.FIX42InteractiveBrokers.OrderCancelReplaceRequest.MsgType: return new QuickFix.FIX42InteractiveBrokers.OrderCancelReplaceRequest();
                    case QuickFix.FIX42InteractiveBrokers.OrderCancelRequest.MsgType: return new QuickFix.FIX42InteractiveBrokers.OrderCancelRequest();
                    case QuickFix.FIX42InteractiveBrokers.OrderCancelReject.MsgType: return new QuickFix.FIX42InteractiveBrokers.OrderCancelReject();
                    case QuickFix.FIX42InteractiveBrokers.OrderStatusRequest.MsgType: return new QuickFix.FIX42InteractiveBrokers.OrderStatusRequest();
                    case QuickFix.FIX42InteractiveBrokers.Allocation.MsgType: return new QuickFix.FIX42InteractiveBrokers.Allocation();
                    case QuickFix.FIX42InteractiveBrokers.AllocationACK.MsgType: return new QuickFix.FIX42InteractiveBrokers.AllocationACK();
                    case QuickFix.FIX42InteractiveBrokers.SettlementInstructions.MsgType: return new QuickFix.FIX42InteractiveBrokers.SettlementInstructions();
                    case QuickFix.FIX42InteractiveBrokers.BidRequest.MsgType: return new QuickFix.FIX42InteractiveBrokers.BidRequest();
                    case QuickFix.FIX42InteractiveBrokers.BidResponse.MsgType: return new QuickFix.FIX42InteractiveBrokers.BidResponse();
                    case QuickFix.FIX42InteractiveBrokers.NewOrderList.MsgType: return new QuickFix.FIX42InteractiveBrokers.NewOrderList();
                    case QuickFix.FIX42InteractiveBrokers.ListStrikePrice.MsgType: return new QuickFix.FIX42InteractiveBrokers.ListStrikePrice();
                    case QuickFix.FIX42InteractiveBrokers.ListStatus.MsgType: return new QuickFix.FIX42InteractiveBrokers.ListStatus();
                    case QuickFix.FIX42InteractiveBrokers.ListExecute.MsgType: return new QuickFix.FIX42InteractiveBrokers.ListExecute();
                    case QuickFix.FIX42InteractiveBrokers.ListCancelRequest.MsgType: return new QuickFix.FIX42InteractiveBrokers.ListCancelRequest();
                    case QuickFix.FIX42InteractiveBrokers.ListStatusRequest.MsgType: return new QuickFix.FIX42InteractiveBrokers.ListStatusRequest();
                    case QuickFix.FIX42InteractiveBrokers.BusinessMessageReject.MsgType: return new QuickFix.FIX42InteractiveBrokers.BusinessMessageReject();
                }

                return new QuickFix.Message();
            }


            public Group Create(string beginString, string msgType, int correspondingFieldID)
            {
                if (QuickFix.FIX42InteractiveBrokers.Logon.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoMsgTypes: return new QuickFix.FIX42InteractiveBrokers.Logon.NoMsgTypesGroup();
                    }
                }

                if (QuickFix.FIX42InteractiveBrokers.IndicationofInterest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoIOIQualifiers: return new QuickFix.FIX42InteractiveBrokers.IndicationofInterest.NoIOIQualifiersGroup();
                        case QuickFix.Fields.Tags.NoRoutingIDs: return new QuickFix.FIX42InteractiveBrokers.IndicationofInterest.NoRoutingIDsGroup();
                    }
                }

                if (QuickFix.FIX42InteractiveBrokers.News.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoRoutingIDs: return new QuickFix.FIX42InteractiveBrokers.News.NoRoutingIDsGroup();
                        case QuickFix.Fields.Tags.NoRelatedSym: return new QuickFix.FIX42InteractiveBrokers.News.NoRelatedSymGroup();
                        case QuickFix.Fields.Tags.LinesOfText: return new QuickFix.FIX42InteractiveBrokers.News.LinesOfTextGroup();
                    }
                }

                if (QuickFix.FIX42InteractiveBrokers.Email.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoRoutingIDs: return new QuickFix.FIX42InteractiveBrokers.Email.NoRoutingIDsGroup();
                        case QuickFix.Fields.Tags.NoRelatedSym: return new QuickFix.FIX42InteractiveBrokers.Email.NoRelatedSymGroup();
                        case QuickFix.Fields.Tags.LinesOfText: return new QuickFix.FIX42InteractiveBrokers.Email.LinesOfTextGroup();
                    }
                }

                if (QuickFix.FIX42InteractiveBrokers.QuoteRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoRelatedSym: return new QuickFix.FIX42InteractiveBrokers.QuoteRequest.NoRelatedSymGroup();
                    }
                }

                if (QuickFix.FIX42InteractiveBrokers.MassQuote.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoQuoteSets: return new QuickFix.FIX42InteractiveBrokers.MassQuote.NoQuoteSetsGroup();
                        case QuickFix.Fields.Tags.NoQuoteEntries: return new QuickFix.FIX42InteractiveBrokers.MassQuote.NoQuoteSetsGroup.NoQuoteEntriesGroup();
                    }
                }

                if (QuickFix.FIX42InteractiveBrokers.QuoteCancel.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoQuoteEntries: return new QuickFix.FIX42InteractiveBrokers.QuoteCancel.NoQuoteEntriesGroup();
                    }
                }

                if (QuickFix.FIX42InteractiveBrokers.QuoteAcknowledgement.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoQuoteSets: return new QuickFix.FIX42InteractiveBrokers.QuoteAcknowledgement.NoQuoteSetsGroup();
                        case QuickFix.Fields.Tags.NoQuoteEntries: return new QuickFix.FIX42InteractiveBrokers.QuoteAcknowledgement.NoQuoteSetsGroup.NoQuoteEntriesGroup();
                    }
                }

                if (QuickFix.FIX42InteractiveBrokers.MarketDataRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoMDEntryTypes: return new QuickFix.FIX42InteractiveBrokers.MarketDataRequest.NoMDEntryTypesGroup();
                        case QuickFix.Fields.Tags.NoRelatedSym: return new QuickFix.FIX42InteractiveBrokers.MarketDataRequest.NoRelatedSymGroup();
                    }
                }

                if (QuickFix.FIX42InteractiveBrokers.MarketDataSnapshotFullRefresh.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoMDEntries: return new QuickFix.FIX42InteractiveBrokers.MarketDataSnapshotFullRefresh.NoMDEntriesGroup();
                    }
                }

                if (QuickFix.FIX42InteractiveBrokers.MarketDataIncrementalRefresh.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoMDEntries: return new QuickFix.FIX42InteractiveBrokers.MarketDataIncrementalRefresh.NoMDEntriesGroup();
                    }
                }

                if (QuickFix.FIX42InteractiveBrokers.SecurityDefinitionRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoRelatedSym: return new QuickFix.FIX42InteractiveBrokers.SecurityDefinitionRequest.NoRelatedSymGroup();
                    }
                }

                if (QuickFix.FIX42InteractiveBrokers.SecurityDefinition.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoRelatedSym: return new QuickFix.FIX42InteractiveBrokers.SecurityDefinition.NoRelatedSymGroup();
                    }
                }

                if (QuickFix.FIX42InteractiveBrokers.NewOrderSingle.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoAllocs: return new QuickFix.FIX42InteractiveBrokers.NewOrderSingle.NoAllocsGroup();
                        case QuickFix.Fields.Tags.NoTradingSessions: return new QuickFix.FIX42InteractiveBrokers.NewOrderSingle.NoTradingSessionsGroup();
                    }
                }

                if (QuickFix.FIX42InteractiveBrokers.ExecutionReport.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoContraBrokers: return new QuickFix.FIX42InteractiveBrokers.ExecutionReport.NoContraBrokersGroup();
                    }
                }

                if (QuickFix.FIX42InteractiveBrokers.OrderCancelReplaceRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoAllocs: return new QuickFix.FIX42InteractiveBrokers.OrderCancelReplaceRequest.NoAllocsGroup();
                        case QuickFix.Fields.Tags.NoTradingSessions: return new QuickFix.FIX42InteractiveBrokers.OrderCancelReplaceRequest.NoTradingSessionsGroup();
                    }
                }

                if (QuickFix.FIX42InteractiveBrokers.Allocation.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoOrders: return new QuickFix.FIX42InteractiveBrokers.Allocation.NoOrdersGroup();
                        case QuickFix.Fields.Tags.NoExecs: return new QuickFix.FIX42InteractiveBrokers.Allocation.NoExecsGroup();
                        case QuickFix.Fields.Tags.NoAllocs: return new QuickFix.FIX42InteractiveBrokers.Allocation.NoAllocsGroup();
                        case QuickFix.Fields.Tags.NoMiscFees: return new QuickFix.FIX42InteractiveBrokers.Allocation.NoAllocsGroup.NoMiscFeesGroup();
                    }
                }

                if (QuickFix.FIX42InteractiveBrokers.BidRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoBidDescriptors: return new QuickFix.FIX42InteractiveBrokers.BidRequest.NoBidDescriptorsGroup();
                        case QuickFix.Fields.Tags.NoBidComponents: return new QuickFix.FIX42InteractiveBrokers.BidRequest.NoBidComponentsGroup();
                    }
                }

                if (QuickFix.FIX42InteractiveBrokers.BidResponse.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoBidComponents: return new QuickFix.FIX42InteractiveBrokers.BidResponse.NoBidComponentsGroup();
                    }
                }

                if (QuickFix.FIX42InteractiveBrokers.NewOrderList.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoOrders: return new QuickFix.FIX42InteractiveBrokers.NewOrderList.NoOrdersGroup();
                        case QuickFix.Fields.Tags.NoAllocs: return new QuickFix.FIX42InteractiveBrokers.NewOrderList.NoOrdersGroup.NoAllocsGroup();
                        case QuickFix.Fields.Tags.NoTradingSessions: return new QuickFix.FIX42InteractiveBrokers.NewOrderList.NoOrdersGroup.NoTradingSessionsGroup();
                    }
                }

                if (QuickFix.FIX42InteractiveBrokers.ListStrikePrice.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoStrikes: return new QuickFix.FIX42InteractiveBrokers.ListStrikePrice.NoStrikesGroup();
                    }
                }

                if (QuickFix.FIX42InteractiveBrokers.ListStatus.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoOrders: return new QuickFix.FIX42InteractiveBrokers.ListStatus.NoOrdersGroup();
                    }
                }

                return null;
            }

        }
    }
}

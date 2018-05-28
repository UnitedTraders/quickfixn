// This is a generated file.  Don't edit it directly!

using System.Collections.Generic;
using QuickFix.FixValues;

namespace QuickFix
{
    namespace FIX42Sterling
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
                    case QuickFix.FIX42Sterling.Heartbeat.MsgType: return new QuickFix.FIX42Sterling.Heartbeat();
                    case QuickFix.FIX42Sterling.Logon.MsgType: return new QuickFix.FIX42Sterling.Logon();
                    case QuickFix.FIX42Sterling.TestRequest.MsgType: return new QuickFix.FIX42Sterling.TestRequest();
                    case QuickFix.FIX42Sterling.ResendRequest.MsgType: return new QuickFix.FIX42Sterling.ResendRequest();
                    case QuickFix.FIX42Sterling.Reject.MsgType: return new QuickFix.FIX42Sterling.Reject();
                    case QuickFix.FIX42Sterling.SequenceReset.MsgType: return new QuickFix.FIX42Sterling.SequenceReset();
                    case QuickFix.FIX42Sterling.Logout.MsgType: return new QuickFix.FIX42Sterling.Logout();
                    case QuickFix.FIX42Sterling.Advertisement.MsgType: return new QuickFix.FIX42Sterling.Advertisement();
                    case QuickFix.FIX42Sterling.IndicationofInterest.MsgType: return new QuickFix.FIX42Sterling.IndicationofInterest();
                    case QuickFix.FIX42Sterling.News.MsgType: return new QuickFix.FIX42Sterling.News();
                    case QuickFix.FIX42Sterling.Email.MsgType: return new QuickFix.FIX42Sterling.Email();
                    case QuickFix.FIX42Sterling.QuoteRequest.MsgType: return new QuickFix.FIX42Sterling.QuoteRequest();
                    case QuickFix.FIX42Sterling.Quote.MsgType: return new QuickFix.FIX42Sterling.Quote();
                    case QuickFix.FIX42Sterling.MassQuote.MsgType: return new QuickFix.FIX42Sterling.MassQuote();
                    case QuickFix.FIX42Sterling.QuoteCancel.MsgType: return new QuickFix.FIX42Sterling.QuoteCancel();
                    case QuickFix.FIX42Sterling.QuoteStatusRequest.MsgType: return new QuickFix.FIX42Sterling.QuoteStatusRequest();
                    case QuickFix.FIX42Sterling.QuoteAcknowledgement.MsgType: return new QuickFix.FIX42Sterling.QuoteAcknowledgement();
                    case QuickFix.FIX42Sterling.MarketDataRequest.MsgType: return new QuickFix.FIX42Sterling.MarketDataRequest();
                    case QuickFix.FIX42Sterling.MarketDataSnapshotFullRefresh.MsgType: return new QuickFix.FIX42Sterling.MarketDataSnapshotFullRefresh();
                    case QuickFix.FIX42Sterling.MarketDataIncrementalRefresh.MsgType: return new QuickFix.FIX42Sterling.MarketDataIncrementalRefresh();
                    case QuickFix.FIX42Sterling.MarketDataRequestReject.MsgType: return new QuickFix.FIX42Sterling.MarketDataRequestReject();
                    case QuickFix.FIX42Sterling.SecurityDefinitionRequest.MsgType: return new QuickFix.FIX42Sterling.SecurityDefinitionRequest();
                    case QuickFix.FIX42Sterling.SecurityDefinition.MsgType: return new QuickFix.FIX42Sterling.SecurityDefinition();
                    case QuickFix.FIX42Sterling.SecurityStatusRequest.MsgType: return new QuickFix.FIX42Sterling.SecurityStatusRequest();
                    case QuickFix.FIX42Sterling.SecurityStatus.MsgType: return new QuickFix.FIX42Sterling.SecurityStatus();
                    case QuickFix.FIX42Sterling.TradingSessionStatusRequest.MsgType: return new QuickFix.FIX42Sterling.TradingSessionStatusRequest();
                    case QuickFix.FIX42Sterling.TradingSessionStatus.MsgType: return new QuickFix.FIX42Sterling.TradingSessionStatus();
                    case QuickFix.FIX42Sterling.NewOrderSingle.MsgType: return new QuickFix.FIX42Sterling.NewOrderSingle();
                    case QuickFix.FIX42Sterling.ExecutionReport.MsgType: return new QuickFix.FIX42Sterling.ExecutionReport();
                    case QuickFix.FIX42Sterling.DontKnowTrade.MsgType: return new QuickFix.FIX42Sterling.DontKnowTrade();
                    case QuickFix.FIX42Sterling.OrderCancelReplaceRequest.MsgType: return new QuickFix.FIX42Sterling.OrderCancelReplaceRequest();
                    case QuickFix.FIX42Sterling.OrderCancelRequest.MsgType: return new QuickFix.FIX42Sterling.OrderCancelRequest();
                    case QuickFix.FIX42Sterling.OrderCancelReject.MsgType: return new QuickFix.FIX42Sterling.OrderCancelReject();
                    case QuickFix.FIX42Sterling.OrderStatusRequest.MsgType: return new QuickFix.FIX42Sterling.OrderStatusRequest();
                    case QuickFix.FIX42Sterling.Allocation.MsgType: return new QuickFix.FIX42Sterling.Allocation();
                    case QuickFix.FIX42Sterling.AllocationACK.MsgType: return new QuickFix.FIX42Sterling.AllocationACK();
                    case QuickFix.FIX42Sterling.SettlementInstructions.MsgType: return new QuickFix.FIX42Sterling.SettlementInstructions();
                    case QuickFix.FIX42Sterling.BidRequest.MsgType: return new QuickFix.FIX42Sterling.BidRequest();
                    case QuickFix.FIX42Sterling.BidResponse.MsgType: return new QuickFix.FIX42Sterling.BidResponse();
                    case QuickFix.FIX42Sterling.NewOrderList.MsgType: return new QuickFix.FIX42Sterling.NewOrderList();
                    case QuickFix.FIX42Sterling.ListStrikePrice.MsgType: return new QuickFix.FIX42Sterling.ListStrikePrice();
                    case QuickFix.FIX42Sterling.ListStatus.MsgType: return new QuickFix.FIX42Sterling.ListStatus();
                    case QuickFix.FIX42Sterling.ListExecute.MsgType: return new QuickFix.FIX42Sterling.ListExecute();
                    case QuickFix.FIX42Sterling.ListCancelRequest.MsgType: return new QuickFix.FIX42Sterling.ListCancelRequest();
                    case QuickFix.FIX42Sterling.ListStatusRequest.MsgType: return new QuickFix.FIX42Sterling.ListStatusRequest();
                    case QuickFix.FIX42Sterling.BusinessMessageReject.MsgType: return new QuickFix.FIX42Sterling.BusinessMessageReject();
                }

                return new QuickFix.Message();
            }


            public Group Create(string beginString, string msgType, int correspondingFieldID)
            {
                if (QuickFix.FIX42Sterling.Logon.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoMsgTypes: return new QuickFix.FIX42Sterling.Logon.NoMsgTypesGroup();
                    }
                }

                if (QuickFix.FIX42Sterling.IndicationofInterest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoIOIQualifiers: return new QuickFix.FIX42Sterling.IndicationofInterest.NoIOIQualifiersGroup();
                        case QuickFix.Fields.Tags.NoRoutingIDs: return new QuickFix.FIX42Sterling.IndicationofInterest.NoRoutingIDsGroup();
                    }
                }

                if (QuickFix.FIX42Sterling.News.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoRoutingIDs: return new QuickFix.FIX42Sterling.News.NoRoutingIDsGroup();
                        case QuickFix.Fields.Tags.NoRelatedSym: return new QuickFix.FIX42Sterling.News.NoRelatedSymGroup();
                        case QuickFix.Fields.Tags.LinesOfText: return new QuickFix.FIX42Sterling.News.LinesOfTextGroup();
                    }
                }

                if (QuickFix.FIX42Sterling.Email.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoRoutingIDs: return new QuickFix.FIX42Sterling.Email.NoRoutingIDsGroup();
                        case QuickFix.Fields.Tags.NoRelatedSym: return new QuickFix.FIX42Sterling.Email.NoRelatedSymGroup();
                        case QuickFix.Fields.Tags.LinesOfText: return new QuickFix.FIX42Sterling.Email.LinesOfTextGroup();
                    }
                }

                if (QuickFix.FIX42Sterling.QuoteRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoRelatedSym: return new QuickFix.FIX42Sterling.QuoteRequest.NoRelatedSymGroup();
                    }
                }

                if (QuickFix.FIX42Sterling.MassQuote.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoQuoteSets: return new QuickFix.FIX42Sterling.MassQuote.NoQuoteSetsGroup();
                        case QuickFix.Fields.Tags.NoQuoteEntries: return new QuickFix.FIX42Sterling.MassQuote.NoQuoteSetsGroup.NoQuoteEntriesGroup();
                    }
                }

                if (QuickFix.FIX42Sterling.QuoteCancel.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoQuoteEntries: return new QuickFix.FIX42Sterling.QuoteCancel.NoQuoteEntriesGroup();
                    }
                }

                if (QuickFix.FIX42Sterling.QuoteAcknowledgement.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoQuoteSets: return new QuickFix.FIX42Sterling.QuoteAcknowledgement.NoQuoteSetsGroup();
                        case QuickFix.Fields.Tags.NoQuoteEntries: return new QuickFix.FIX42Sterling.QuoteAcknowledgement.NoQuoteSetsGroup.NoQuoteEntriesGroup();
                    }
                }

                if (QuickFix.FIX42Sterling.MarketDataRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoMDEntryTypes: return new QuickFix.FIX42Sterling.MarketDataRequest.NoMDEntryTypesGroup();
                        case QuickFix.Fields.Tags.NoRelatedSym: return new QuickFix.FIX42Sterling.MarketDataRequest.NoRelatedSymGroup();
                    }
                }

                if (QuickFix.FIX42Sterling.MarketDataSnapshotFullRefresh.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoMDEntries: return new QuickFix.FIX42Sterling.MarketDataSnapshotFullRefresh.NoMDEntriesGroup();
                    }
                }

                if (QuickFix.FIX42Sterling.MarketDataIncrementalRefresh.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoMDEntries: return new QuickFix.FIX42Sterling.MarketDataIncrementalRefresh.NoMDEntriesGroup();
                    }
                }

                if (QuickFix.FIX42Sterling.SecurityDefinitionRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoRelatedSym: return new QuickFix.FIX42Sterling.SecurityDefinitionRequest.NoRelatedSymGroup();
                    }
                }

                if (QuickFix.FIX42Sterling.SecurityDefinition.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoRelatedSym: return new QuickFix.FIX42Sterling.SecurityDefinition.NoRelatedSymGroup();
                    }
                }

                if (QuickFix.FIX42Sterling.NewOrderSingle.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoAllocs: return new QuickFix.FIX42Sterling.NewOrderSingle.NoAllocsGroup();
                        case QuickFix.Fields.Tags.NoTradingSessions: return new QuickFix.FIX42Sterling.NewOrderSingle.NoTradingSessionsGroup();
                    }
                }

                if (QuickFix.FIX42Sterling.ExecutionReport.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoContraBrokers: return new QuickFix.FIX42Sterling.ExecutionReport.NoContraBrokersGroup();
                    }
                }

                if (QuickFix.FIX42Sterling.OrderCancelReplaceRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoAllocs: return new QuickFix.FIX42Sterling.OrderCancelReplaceRequest.NoAllocsGroup();
                        case QuickFix.Fields.Tags.NoTradingSessions: return new QuickFix.FIX42Sterling.OrderCancelReplaceRequest.NoTradingSessionsGroup();
                    }
                }

                if (QuickFix.FIX42Sterling.Allocation.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoOrders: return new QuickFix.FIX42Sterling.Allocation.NoOrdersGroup();
                        case QuickFix.Fields.Tags.NoExecs: return new QuickFix.FIX42Sterling.Allocation.NoExecsGroup();
                        case QuickFix.Fields.Tags.NoAllocs: return new QuickFix.FIX42Sterling.Allocation.NoAllocsGroup();
                        case QuickFix.Fields.Tags.NoMiscFees: return new QuickFix.FIX42Sterling.Allocation.NoAllocsGroup.NoMiscFeesGroup();
                    }
                }

                if (QuickFix.FIX42Sterling.BidRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoBidDescriptors: return new QuickFix.FIX42Sterling.BidRequest.NoBidDescriptorsGroup();
                        case QuickFix.Fields.Tags.NoBidComponents: return new QuickFix.FIX42Sterling.BidRequest.NoBidComponentsGroup();
                    }
                }

                if (QuickFix.FIX42Sterling.BidResponse.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoBidComponents: return new QuickFix.FIX42Sterling.BidResponse.NoBidComponentsGroup();
                    }
                }

                if (QuickFix.FIX42Sterling.NewOrderList.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoOrders: return new QuickFix.FIX42Sterling.NewOrderList.NoOrdersGroup();
                        case QuickFix.Fields.Tags.NoAllocs: return new QuickFix.FIX42Sterling.NewOrderList.NoOrdersGroup.NoAllocsGroup();
                        case QuickFix.Fields.Tags.NoTradingSessions: return new QuickFix.FIX42Sterling.NewOrderList.NoOrdersGroup.NoTradingSessionsGroup();
                    }
                }

                if (QuickFix.FIX42Sterling.ListStrikePrice.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoStrikes: return new QuickFix.FIX42Sterling.ListStrikePrice.NoStrikesGroup();
                    }
                }

                if (QuickFix.FIX42Sterling.ListStatus.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoOrders: return new QuickFix.FIX42Sterling.ListStatus.NoOrdersGroup();
                    }
                }

                return null;
            }

        }
    }
}

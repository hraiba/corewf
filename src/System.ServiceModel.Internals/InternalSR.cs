// This file is part of Core WF which is licensed under the MIT license.
// See LICENSE file in the project root for full license information.

using System.Reflection;
using System.Resources;

namespace System.Runtime
{
    public class InternalSR : StringResourceBase
    {
        internal static readonly InternalSR Instance = new InternalSR();

        private ResourceManager _resourceManager;

        protected internal override ResourceManager ResourceManager
        {
            get
            {
                if (_resourceManager == null)
                {
                    _resourceManager = new ResourceManager("System.Activities.Resources", typeof(InternalSR).GetTypeInfo().Assembly);
                }
                return _resourceManager;
            }
        }

        internal static string AbortingDueToDynamicUpdateFailure { get { return InternalSR.Instance["AbortingDueToDynamicUpdateFailure"]; } }
        internal static string AbortingDueToInstanceTimeout { get { return InternalSR.Instance["AbortingDueToInstanceTimeout"]; } }
        internal static string AbortingDueToLoadFailure { get { return InternalSR.Instance["AbortingDueToLoadFailure"]; } }
        internal static string AbortingDueToVersionMismatch { get { return InternalSR.Instance["AbortingDueToVersionMismatch"]; } }
        internal static string AbortInstanceOnTransactionFailureDoesNotMatch { get { return InternalSR.Instance["AbortInstanceOnTransactionFailureDoesNotMatch"]; } }
        internal static string ActionItemIsAlreadyScheduled { get { return InternalSR.Instance["ActionItemIsAlreadyScheduled"]; } }
        internal static string ActivityBlockingUpdate(object p0, object p1) { return InternalSR.Instance["ActivityBlockingUpdate", p0, p1]; }
        internal static string ActivityCannotBeReferenced(object p0, object p1, object p2, object p3) { return InternalSR.Instance["ActivityCannotBeReferenced", p0, p1, p2, p3]; }
        internal static string ActivityCannotBeReferencedWithoutTarget(object p0, object p1, object p2) { return InternalSR.Instance["ActivityCannotBeReferencedWithoutTarget", p0, p1, p2]; }
        internal static string ActivityCannotReferenceItself(object p0) { return InternalSR.Instance["ActivityCannotReferenceItself", p0]; }
        internal static string ActivityDefinitionCannotBeShared(object p0) { return InternalSR.Instance["ActivityDefinitionCannotBeShared", p0]; }
        internal static string ActivityDelegateAlreadyOpened(object p0, object p1, object p2) { return InternalSR.Instance["ActivityDelegateAlreadyOpened", p0, p1, p2]; }
        internal static string ActivityDelegateCannotBeReferenced(object p0, object p1, object p2, object p3) { return InternalSR.Instance["ActivityDelegateCannotBeReferenced", p0, p1, p2, p3]; }
        internal static string ActivityDelegateCannotBeReferencedNoHandler(object p0, object p1, object p2) { return InternalSR.Instance["ActivityDelegateCannotBeReferencedNoHandler", p0, p1, p2]; }
        internal static string ActivityDelegateCannotBeReferencedWithoutTarget(object p0, object p1, object p2) { return InternalSR.Instance["ActivityDelegateCannotBeReferencedWithoutTarget", p0, p1, p2]; }
        internal static string ActivityDelegateCannotBeReferencedWithoutTargetNoHandler(object p0, object p1) { return InternalSR.Instance["ActivityDelegateCannotBeReferencedWithoutTargetNoHandler", p0, p1]; }
        internal static string ActivityDelegateHandlersMustBeDeclarations(object p0, object p1, object p2) { return InternalSR.Instance["ActivityDelegateHandlersMustBeDeclarations", p0, p1, p2]; }
        internal static string ActivityDelegateNotOpened(object p0) { return InternalSR.Instance["ActivityDelegateNotOpened", p0]; }
        internal static string ActivityDelegateOwnerEnvironmentMissing(object p0, object p1) { return InternalSR.Instance["ActivityDelegateOwnerEnvironmentMissing", p0, p1]; }
        internal static string ActivityDelegateOwnerMissing(object p0) { return InternalSR.Instance["ActivityDelegateOwnerMissing", p0]; }
        internal static string ActivityDelegateOwnerNotInParentScope(object p0, object p1) { return InternalSR.Instance["ActivityDelegateOwnerNotInParentScope", p0, p1]; }
        internal static string ActivityFailedToOpenBefore { get { return InternalSR.Instance["ActivityFailedToOpenBefore"]; } }
        internal static string ActivityHasNoImplementation(object p0) { return InternalSR.Instance["ActivityHasNoImplementation", p0]; }
        internal static string ActivityInstanceFixupFailed { get { return InternalSR.Instance["ActivityInstanceFixupFailed"]; } }
        internal static string ActivityIsNotRoot { get { return InternalSR.Instance["ActivityIsNotRoot"]; } }
        internal static string ActivityIsUncached { get { return InternalSR.Instance["ActivityIsUncached"]; } }
        internal static string ActivityMapIsCorrupt { get { return InternalSR.Instance["ActivityMapIsCorrupt"]; } }
        internal static string ActivityNotFound(object p0) { return InternalSR.Instance["ActivityNotFound", p0]; }
        internal static string ActivityNotICompiledExpressionRoot { get { return InternalSR.Instance["ActivityNotICompiledExpressionRoot"]; } }
        internal static string ActivityNotPartOfThisTree(object p0, object p1) { return InternalSR.Instance["ActivityNotPartOfThisTree", p0, p1]; }
        internal static string ActivityPropertyMustBeSet(object p0, object p1) { return InternalSR.Instance["ActivityPropertyMustBeSet", p0, p1]; }
        internal static string ActivityPropertyNotSet(object p0, object p1) { return InternalSR.Instance["ActivityPropertyNotSet", p0, p1]; }
        internal static string ActivityPropertyRequiresName(object p0) { return InternalSR.Instance["ActivityPropertyRequiresName", p0]; }
        internal static string ActivityPropertyRequiresType(object p0) { return InternalSR.Instance["ActivityPropertyRequiresType", p0]; }
        internal static string ActivityTypeMismatch(object p0, object p1) { return InternalSR.Instance["ActivityTypeMismatch", p0, p1]; }
        internal static string ActivityXamlServiceLineString { get { return InternalSR.Instance["ActivityXamlServiceLineString"]; } }
        internal static string ActivityXamlServicesCompilationFailed(object p0) { return InternalSR.Instance["ActivityXamlServicesCompilationFailed", p0]; }
        internal static string ActivityXamlServicesRequiresActivity(object p0) { return InternalSR.Instance["ActivityXamlServicesRequiresActivity", p0]; }
        internal static string AddedIdleArgumentBlockDU(object p0, object p1) { return InternalSR.Instance["AddedIdleArgumentBlockDU", p0, p1]; }
        internal static string AddedIdleExpressionBlockDU { get { return InternalSR.Instance["AddedIdleExpressionBlockDU"]; } }
        internal static string AddedIdleVariableDefaultBlockDU(object p0, object p1) { return InternalSR.Instance["AddedIdleVariableDefaultBlockDU", p0, p1]; }
        internal static string AddMatchActivityNewAndOldParentMismatch(object p0, object p1, object p2, object p3) { return InternalSR.Instance["AddMatchActivityNewAndOldParentMismatch", p0, p1, p2, p3]; }
        internal static string AddMatchActivityNewParentMismatch(object p0, object p1, object p2) { return InternalSR.Instance["AddMatchActivityNewParentMismatch", p0, p1, p2]; }
        internal static string AddMatchActivityPrivateChild(object p0) { return InternalSR.Instance["AddMatchActivityPrivateChild", p0]; }
        internal static string AddMatchVariableNewAndOldParentMismatch(object p0, object p1, object p2, object p3) { return InternalSR.Instance["AddMatchVariableNewAndOldParentMismatch", p0, p1, p2, p3]; }
        internal static string AddMatchVariableNewParentMismatch(object p0, object p1, object p2) { return InternalSR.Instance["AddMatchVariableNewParentMismatch", p0, p1, p2]; }
        internal static string AddMatchVariablePrivateChild(object p0) { return InternalSR.Instance["AddMatchVariablePrivateChild", p0]; }
        internal static string AddMatchVariableSignatureMismatch(object p0, object p1, object p2, object p3, object p4, object p5, object p6) { return InternalSR.Instance["AddMatchVariableSignatureMismatch", p0, p1, p2, p3, p4, p5, p6]; }
        internal static string AddValidationErrorMustBeCalledFromConstraint(object p0) { return InternalSR.Instance["AddValidationErrorMustBeCalledFromConstraint", p0]; }
        internal static string AECDisposed { get { return InternalSR.Instance["AECDisposed"]; } }
        internal static string AECForPropertiesHasBeenDisposed { get { return InternalSR.Instance["AECForPropertiesHasBeenDisposed"]; } }
        internal static string AlreadyBoundToInstance { get { return InternalSR.Instance["AlreadyBoundToInstance"]; } }
        internal static string AlreadyBoundToOwner { get { return InternalSR.Instance["AlreadyBoundToOwner"]; } }
        internal static string AlreadySetupNoPersist { get { return InternalSR.Instance["AlreadySetupNoPersist"]; } }
        internal static string AmbiguousVBVariableReference(object p0) { return InternalSR.Instance["AmbiguousVBVariableReference", p0]; }
        internal static string ArgumentAlreadyInitialized(object p0, object p1) { return InternalSR.Instance["ArgumentAlreadyInitialized", p0, p1]; }
        internal static string ArgumentAlreadyInUse(object p0, object p1, object p2) { return InternalSR.Instance["ArgumentAlreadyInUse", p0, p1, p2]; }
        internal static string ArgumentDirectionMismatch(object p0, object p1, object p2) { return InternalSR.Instance["ArgumentDirectionMismatch", p0, p1, p2]; }
        internal static string ArgumentDoesNotExist(object p0) { return InternalSR.Instance["ArgumentDoesNotExist", p0]; }
        internal static string ArgumentDoesNotExistInEnvironment(object p0) { return InternalSR.Instance["ArgumentDoesNotExistInEnvironment", p0]; }
        internal static string ArgumentIsAddedMoreThanOnce(object p0, object p1) { return InternalSR.Instance["ArgumentIsAddedMoreThanOnce", p0, p1]; }
        internal static string ArgumentLocationExpressionTypeMismatch(object p0, object p1) { return InternalSR.Instance["ArgumentLocationExpressionTypeMismatch", p0, p1]; }
        internal static string ArgumentMustbePropertyofWorkflowElement { get { return InternalSR.Instance["ArgumentMustbePropertyofWorkflowElement"]; } }
        internal static string ArgumentNameRequired { get { return InternalSR.Instance["ArgumentNameRequired"]; } }
        internal static string ArgumentNotFound(object p0) { return InternalSR.Instance["ArgumentNotFound", p0]; }
        internal static string ArgumentNotInTree(object p0) { return InternalSR.Instance["ArgumentNotInTree", p0]; }
        internal static string ArgumentNullOrEmpty(object p0) { return InternalSR.Instance["ArgumentNullOrEmpty", p0]; }
        internal static string ArgumentNumberRequiresTheSameAsParameterNumber(object p0) { return InternalSR.Instance["ArgumentNumberRequiresTheSameAsParameterNumber", p0]; }
        internal static string ArgumentRequired(object p0, object p1) { return InternalSR.Instance["ArgumentRequired", p0, p1]; }
        internal static string ArgumentTypeCannotBeNull { get { return InternalSR.Instance["ArgumentTypeCannotBeNull"]; } }
        internal static string ArgumentTypeMismatch(object p0, object p1, object p2) { return InternalSR.Instance["ArgumentTypeMismatch", p0, p1, p2]; }
        internal static string ArgumentTypeMustBeCompatible(object p0, object p1, object p2) { return InternalSR.Instance["ArgumentTypeMustBeCompatible", p0, p1, p2]; }
        internal static string ArgumentValueExpressionTypeMismatch(object p0, object p1) { return InternalSR.Instance["ArgumentValueExpressionTypeMismatch", p0, p1]; }
        internal static string ArgumentViolationsFound(object p0, object p1) { return InternalSR.Instance["ArgumentViolationsFound", p0, p1]; }
        internal static string AssemblyReferenceIsImmutable { get { return InternalSR.Instance["AssemblyReferenceIsImmutable"]; } }
        internal static string AsyncCallbackThrewException { get { return InternalSR.Instance["AsyncCallbackThrewException"]; } }
        internal static string AsyncEventArgsCompletedTwice(object p0) { return InternalSR.Instance["AsyncEventArgsCompletedTwice", p0]; }
        internal static string AsyncEventArgsCompletionPending(object p0) { return InternalSR.Instance["AsyncEventArgsCompletionPending", p0]; }
        internal static string AsyncMethodsMustAllBeStaticOrInstance { get { return InternalSR.Instance["AsyncMethodsMustAllBeStaticOrInstance"]; } }
        internal static string AsyncMethodsMustFromSameType { get { return InternalSR.Instance["AsyncMethodsMustFromSameType"]; } }
        internal static string AsyncResultAlreadyEnded { get { return InternalSR.Instance["AsyncResultAlreadyEnded"]; } }
        internal static string AsyncResultCompletedTwice(object p0) { return InternalSR.Instance["AsyncResultCompletedTwice", p0]; }
        internal static string AsyncTransactionException { get { return InternalSR.Instance["AsyncTransactionException"]; } }
        internal static string BadCopyToArray { get { return InternalSR.Instance["BadCopyToArray"]; } }
        internal static string BadWorkflowIdentityFormat { get { return InternalSR.Instance["BadWorkflowIdentityFormat"]; } }
        internal static string BeforeInitializeComponentXBTExtensionResourceNotFound { get { return InternalSR.Instance["BeforeInitializeComponentXBTExtensionResourceNotFound"]; } }
        internal static string BeginExecuteMustNotReturnANullAsyncResult { get { return InternalSR.Instance["BeginExecuteMustNotReturnANullAsyncResult"]; } }
        internal static string BeginExecuteMustUseProvidedStateAsAsyncResultState { get { return InternalSR.Instance["BeginExecuteMustUseProvidedStateAsAsyncResultState"]; } }
        internal static string BinaryExpressionActivityRequiresArgument(object p0, object p1, object p2) { return InternalSR.Instance["BinaryExpressionActivityRequiresArgument", p0, p1, p2]; }
        internal static string BindLockRequiresCommandFlag { get { return InternalSR.Instance["BindLockRequiresCommandFlag"]; } }
        internal static string BindReclaimedLockException { get { return InternalSR.Instance["BindReclaimedLockException"]; } }
        internal static string BindReclaimSucceeded { get { return InternalSR.Instance["BindReclaimSucceeded"]; } }
        internal static string BlockedUpdateInsideActivityUpdateByUserError { get { return InternalSR.Instance["BlockedUpdateInsideActivityUpdateByUserError"]; } }
        internal static string BlockedUpdateInsideActivityUpdateError { get { return InternalSR.Instance["BlockedUpdateInsideActivityUpdateError"]; } }
        internal static string BookmarkAlreadyExists(object p0) { return InternalSR.Instance["BookmarkAlreadyExists", p0]; }
        internal static string BookmarkNotFoundGeneric { get { return InternalSR.Instance["BookmarkNotFoundGeneric"]; } }
        internal static string BookmarkNotRegistered(object p0) { return InternalSR.Instance["BookmarkNotRegistered", p0]; }
        internal static string BookmarkScopeAlreadyInitialized { get { return InternalSR.Instance["BookmarkScopeAlreadyInitialized"]; } }
        internal static string BookmarkScopeHasBookmarks { get { return InternalSR.Instance["BookmarkScopeHasBookmarks"]; } }
        internal static string BookmarkScopeNotFound(object p0) { return InternalSR.Instance["BookmarkScopeNotFound", p0]; }
        internal static string BookmarkScopeNotRegisteredForInitialize { get { return InternalSR.Instance["BookmarkScopeNotRegisteredForInitialize"]; } }
        internal static string BookmarkScopeNotRegisteredForUnregister { get { return InternalSR.Instance["BookmarkScopeNotRegisteredForUnregister"]; } }
        internal static string BookmarkScopesRequireKeys { get { return InternalSR.Instance["BookmarkScopesRequireKeys"]; } }
        internal static string BookmarkScopeWithIdAlreadyExists(object p0) { return InternalSR.Instance["BookmarkScopeWithIdAlreadyExists", p0]; }
        internal static string BookmarksOnlyResumableWhileIdle { get { return InternalSR.Instance["BookmarksOnlyResumableWhileIdle"]; } }
        internal static string BufferAllocationFailed(object p0) { return InternalSR.Instance["BufferAllocationFailed", p0]; }
        internal static string BufferedOutputStreamQuotaExceeded(object p0) { return InternalSR.Instance["BufferedOutputStreamQuotaExceeded", p0]; }
        internal static string BufferIsNotRightSizeForBufferManager { get { return InternalSR.Instance["BufferIsNotRightSizeForBufferManager"]; } }
        internal static string CallbackExceptionFromHostAbort(object p0) { return InternalSR.Instance["CallbackExceptionFromHostAbort", p0]; }
        internal static string CallbackExceptionFromHostGetExtension(object p0) { return InternalSR.Instance["CallbackExceptionFromHostGetExtension", p0]; }
        internal static string CancellationHandlerFatalException(object p0) { return InternalSR.Instance["CancellationHandlerFatalException", p0]; }
        internal static string CanInduceIdleActivityInArgumentExpression(object p0, object p1, object p2) { return InternalSR.Instance["CanInduceIdleActivityInArgumentExpression", p0, p1, p2]; }
        internal static string CanInduceIdleNotSpecified(object p0) { return InternalSR.Instance["CanInduceIdleNotSpecified", p0]; }
        internal static string CannotAcquireLockDefault { get { return InternalSR.Instance["CannotAcquireLockDefault"]; } }
        internal static string CannotAcquireLockSpecific(object p0) { return InternalSR.Instance["CannotAcquireLockSpecific", p0]; }
        internal static string CannotAcquireLockSpecificWithOwner(object p0, object p1) { return InternalSR.Instance["CannotAcquireLockSpecificWithOwner", p0, p1]; }
        internal static string CannotAddHandlesUpdateError { get { return InternalSR.Instance["CannotAddHandlesUpdateError"]; } }
        internal static string CannotAddOrRemoveWithChildren { get { return InternalSR.Instance["CannotAddOrRemoveWithChildren"]; } }
        internal static string CannotCallAbortInstanceFromWorkflowThread { get { return InternalSR.Instance["CannotCallAbortInstanceFromWorkflowThread"]; } }
        internal static string CannotChangeAbortInstanceFlagAfterPropertyRegistration { get { return InternalSR.Instance["CannotChangeAbortInstanceFlagAfterPropertyRegistration"]; } }
        internal static string CannotChangeMatchesInImplementation { get { return InternalSR.Instance["CannotChangeMatchesInImplementation"]; } }
        internal static string CannotCompleteRuntimeOwnedTransaction { get { return InternalSR.Instance["CannotCompleteRuntimeOwnedTransaction"]; } }
        internal static string CannotCompleteWithKeys { get { return InternalSR.Instance["CannotCompleteWithKeys"]; } }
        internal static string CannotConvertObject(object p0, object p1) { return InternalSR.Instance["CannotConvertObject", p0, p1]; }
        internal static string CannotCreateContextWithNullId { get { return InternalSR.Instance["CannotCreateContextWithNullId"]; } }
        internal static string CannotCreateOwnerWithoutIdentity { get { return InternalSR.Instance["CannotCreateOwnerWithoutIdentity"]; } }
        internal static string CannotDereferenceNull(object p0) { return InternalSR.Instance["CannotDereferenceNull", p0]; }
        internal static string CannotEnlistMultipleTransactions { get { return InternalSR.Instance["CannotEnlistMultipleTransactions"]; } }
        internal static string CanNotFindSymbolResolverInWorkflowInstanceExtensions { get { return InternalSR.Instance["CanNotFindSymbolResolverInWorkflowInstanceExtensions"]; } }
        internal static string CannotGenerateSchemaForXmlSerializable(object p0) { return InternalSR.Instance["CannotGenerateSchemaForXmlSerializable", p0]; }
        internal static string CannotGetValueOfOutArgument { get { return InternalSR.Instance["CannotGetValueOfOutArgument"]; } }
        internal static string CannotInvokeBindingFromNonBinding { get { return InternalSR.Instance["CannotInvokeBindingFromNonBinding"]; } }
        internal static string CannotInvokeOpenedActivity { get { return InternalSR.Instance["CannotInvokeOpenedActivity"]; } }
        internal static string CannotInvokeTransactionalFromNonTransactional { get { return InternalSR.Instance["CannotInvokeTransactionalFromNonTransactional"]; } }
        internal static string CannotModifyCatchAfterOpen { get { return InternalSR.Instance["CannotModifyCatchAfterOpen"]; } }
        internal static string CannotMoveChildAcrossDifferentFlowNodeTypes { get { return InternalSR.Instance["CannotMoveChildAcrossDifferentFlowNodeTypes"]; } }
        internal static string CannotNestTransactionScopeWhenAmbientHandleIsSuppressed(object p0) { return InternalSR.Instance["CannotNestTransactionScopeWhenAmbientHandleIsSuppressed", p0]; }
        internal static string CannotPerformOperationFromHandlerThread { get { return InternalSR.Instance["CannotPerformOperationFromHandlerThread"]; } }
        internal static string CannotPerformOperationOnHandle { get { return InternalSR.Instance["CannotPerformOperationOnHandle"]; } }
        internal static string CannotPersistInsideIsolation { get { return InternalSR.Instance["CannotPersistInsideIsolation"]; } }
        internal static string CannotPersistInsideNoPersist { get { return InternalSR.Instance["CannotPersistInsideNoPersist"]; } }
        internal static string CannotPersistWhileDetached { get { return InternalSR.Instance["CannotPersistWhileDetached"]; } }
        internal static string CannotPropagateExceptionWhileCanceling(object p0, object p1) { return InternalSR.Instance["CannotPropagateExceptionWhileCanceling", p0, p1]; }
        internal static string CannotRemoveExecutingActivityUpdateError(object p0, object p1) { return InternalSR.Instance["CannotRemoveExecutingActivityUpdateError", p0, p1]; }
        internal static string CannotReplaceTransaction { get { return InternalSR.Instance["CannotReplaceTransaction"]; } }
        internal static string CannotResetPropertyInDataContext { get { return InternalSR.Instance["CannotResetPropertyInDataContext"]; } }
        internal static string CannotSaveOriginalValueForActivity { get { return InternalSR.Instance["CannotSaveOriginalValueForActivity"]; } }
        internal static string CannotSaveOriginalValueForNewActivity(object p0) { return InternalSR.Instance["CannotSaveOriginalValueForNewActivity", p0]; }
        internal static string CannotSaveOriginalValuesForReferencedChildren { get { return InternalSR.Instance["CannotSaveOriginalValuesForReferencedChildren"]; } }
        internal static string CannotScheduleChildrenWhileEnteringIsolation { get { return InternalSR.Instance["CannotScheduleChildrenWhileEnteringIsolation"]; } }
        internal static string CannotSerializeExpression(object p0) { return InternalSR.Instance["CannotSerializeExpression", p0]; }
        internal static string CannotSerializeVariableExpression { get { return InternalSR.Instance["CannotSerializeVariableExpression"]; } }
        internal static string CannotSetRuntimeTransactionInNoPersist { get { return InternalSR.Instance["CannotSetRuntimeTransactionInNoPersist"]; } }
        internal static string CannotSetupIsolationInsideIsolation { get { return InternalSR.Instance["CannotSetupIsolationInsideIsolation"]; } }
        internal static string CannotSetupIsolationInsideNoPersist { get { return InternalSR.Instance["CannotSetupIsolationInsideNoPersist"]; } }
        internal static string CannotSetupIsolationWithChildren { get { return InternalSR.Instance["CannotSetupIsolationWithChildren"]; } }
        internal static string CannotSetValueOfInArgument { get { return InternalSR.Instance["CannotSetValueOfInArgument"]; } }
        internal static string CannotSetValueToLocation(object p0, object p1, object p2) { return InternalSR.Instance["CannotSetValueToLocation", p0, p1, p2]; }
        internal static string CannotSuppressAlreadyRegisteredHandle { get { return InternalSR.Instance["CannotSuppressAlreadyRegisteredHandle"]; } }
        internal static string CannotUnregisterDefaultBookmarkScope { get { return InternalSR.Instance["CannotUnregisterDefaultBookmarkScope"]; } }
        internal static string CannotUnregisterNullBookmarkScope { get { return InternalSR.Instance["CannotUnregisterNullBookmarkScope"]; } }
        internal static string CannotUpdateEnvironmentInTheMiddleOfResolvingArguments { get { return InternalSR.Instance["CannotUpdateEnvironmentInTheMiddleOfResolvingArguments"]; } }
        internal static string CannotUpdateEnvironmentInTheMiddleOfResolvingVariables { get { return InternalSR.Instance["CannotUpdateEnvironmentInTheMiddleOfResolvingVariables"]; } }
        internal static string CannotUseInputsWithLoad { get { return InternalSR.Instance["CannotUseInputsWithLoad"]; } }
        internal static string CannotValidateNullObject(object p0, object p1) { return InternalSR.Instance["CannotValidateNullObject", p0, p1]; }
        internal static string CannotWaitForIdleSynchronously { get { return InternalSR.Instance["CannotWaitForIdleSynchronously"]; } }
        internal static string CanOnlyAbortDirectChildren { get { return InternalSR.Instance["CanOnlyAbortDirectChildren"]; } }
        internal static string CanOnlyCancelDirectChildren { get { return InternalSR.Instance["CanOnlyCancelDirectChildren"]; } }
        internal static string CanOnlyGetOwnedArguments(object p0, object p1, object p2) { return InternalSR.Instance["CanOnlyGetOwnedArguments", p0, p1, p2]; }
        internal static string CanOnlyScheduleDirectChildren(object p0, object p1, object p2) { return InternalSR.Instance["CanOnlyScheduleDirectChildren", p0, p1, p2]; }
        internal static string CantFindTimerExtension { get { return InternalSR.Instance["CantFindTimerExtension"]; } }
        internal static string CatchOrFinallyExpected(object p0) { return InternalSR.Instance["CatchOrFinallyExpected", p0]; }
        internal static string ChangeConditionalTransitionToUnconditionalBlockDU { get { return InternalSR.Instance["ChangeConditionalTransitionToUnconditionalBlockDU"]; } }
        internal static string ChangeTransitionTypeDuringTransitioningBlockDU { get { return InternalSR.Instance["ChangeTransitionTypeDuringTransitioningBlockDU"]; } }
        internal static string ChangingTriggerOrUseOriginalConditionActionBlockDU { get { return InternalSR.Instance["ChangingTriggerOrUseOriginalConditionActionBlockDU"]; } }
        internal static string CollectionActivityRequiresCollection(object p0) { return InternalSR.Instance["CollectionActivityRequiresCollection", p0]; }
        internal static string ColumnNumberTooLarge(object p0) { return InternalSR.Instance["ColumnNumberTooLarge", p0]; }
        internal static string CommandExecutionCannotOverlap { get { return InternalSR.Instance["CommandExecutionCannotOverlap"]; } }
        internal static string CompensableActivityAlreadyConfirmedOrCompensated { get { return InternalSR.Instance["CompensableActivityAlreadyConfirmedOrCompensated"]; } }
        internal static string CompensableActivityInsideTransactionScopeActivity { get { return InternalSR.Instance["CompensableActivityInsideTransactionScopeActivity"]; } }
        internal static string CompensateWithNoTargetConstraint { get { return InternalSR.Instance["CompensateWithNoTargetConstraint"]; } }
        internal static string CompensateWithoutCompensableActivity(object p0) { return InternalSR.Instance["CompensateWithoutCompensableActivity", p0]; }
        internal static string CompensationHandlerFatalException(object p0) { return InternalSR.Instance["CompensationHandlerFatalException", p0]; }
        internal static string CompiledExpressionIdNotFound(object p0) { return InternalSR.Instance["CompiledExpressionIdNotFound", p0]; }
        internal static string CompiledExpressionsActivityException(object p0, object p1, object p2) { return InternalSR.Instance["CompiledExpressionsActivityException", p0, p1, p2]; }
        internal static string CompiledExpressionsCacheMetadataException(object p0, object p1) { return InternalSR.Instance["CompiledExpressionsCacheMetadataException", p0, p1]; }
        internal static string CompiledExpressionsDuplicateName(object p0) { return InternalSR.Instance["CompiledExpressionsDuplicateName", p0]; }
        internal static string CompiledExpressionsIgnoringInvalidIdentifierVariable(object p0) { return InternalSR.Instance["CompiledExpressionsIgnoringInvalidIdentifierVariable", p0]; }
        internal static string CompiledExpressionsIgnoringUnnamedVariable { get { return InternalSR.Instance["CompiledExpressionsIgnoringUnnamedVariable"]; } }
        internal static string CompiledExpressionsNoCompiledRoot(object p0) { return InternalSR.Instance["CompiledExpressionsNoCompiledRoot", p0]; }
        internal static string CompiledLocationNoDefaultConstructor(object p0) { return InternalSR.Instance["CompiledLocationNoDefaultConstructor", p0]; }
        internal static string CompiledLocationReferenceGetLocation { get { return InternalSR.Instance["CompiledLocationReferenceGetLocation"]; } }
        internal static string CompilerError { get { return InternalSR.Instance["CompilerError"]; } }
        internal static string CompilerErrorSpecificExpression(object p0, object p1) { return InternalSR.Instance["CompilerErrorSpecificExpression", p0, p1]; }
        internal static string CompletedMustNotHaveAssociatedKeys { get { return InternalSR.Instance["CompletedMustNotHaveAssociatedKeys"]; } }
        internal static string CompletionConditionSetButNoBody(object p0) { return InternalSR.Instance["CompletionConditionSetButNoBody", p0]; }
        internal static string ConfirmationHandlerFatalException(object p0) { return InternalSR.Instance["ConfirmationHandlerFatalException", p0]; }
        internal static string ConfirmWithNoTargetConstraint { get { return InternalSR.Instance["ConfirmWithNoTargetConstraint"]; } }
        internal static string ConfirmWithoutCompensableActivity(object p0) { return InternalSR.Instance["ConfirmWithoutCompensableActivity", p0]; }
        internal static string ConstructorInfoNotFound(object p0) { return InternalSR.Instance["ConstructorInfoNotFound", p0]; }
        internal static string ConstVariableCannotBeSet { get { return InternalSR.Instance["ConstVariableCannotBeSet"]; } }
        internal static string ContextAlreadyBoundToInstance { get { return InternalSR.Instance["ContextAlreadyBoundToInstance"]; } }
        internal static string ContextAlreadyBoundToLock { get { return InternalSR.Instance["ContextAlreadyBoundToLock"]; } }
        internal static string ContextAlreadyBoundToOwner { get { return InternalSR.Instance["ContextAlreadyBoundToOwner"]; } }
        internal static string ContextMustBeBoundToInstance { get { return InternalSR.Instance["ContextMustBeBoundToInstance"]; } }
        internal static string ContextMustBeBoundToOwner { get { return InternalSR.Instance["ContextMustBeBoundToOwner"]; } }
        internal static string ContextNotFromThisStore { get { return InternalSR.Instance["ContextNotFromThisStore"]; } }
        internal static string ControllerInvalidBeforeInitialize { get { return InternalSR.Instance["ControllerInvalidBeforeInitialize"]; } }
        internal static string ConvertVariableToValueExpressionFailed(object p0, object p1) { return InternalSR.Instance["ConvertVariableToValueExpressionFailed", p0, p1]; }
        internal static string CopyToIndexOutOfRange { get { return InternalSR.Instance["CopyToIndexOutOfRange"]; } }
        internal static string CopyToNotEnoughSpaceInArray { get { return InternalSR.Instance["CopyToNotEnoughSpaceInArray"]; } }
        internal static string CopyToRankMustBeOne { get { return InternalSR.Instance["CopyToRankMustBeOne"]; } }
        internal static string CouldNotResolveNamespacePrefix(object p0) { return InternalSR.Instance["CouldNotResolveNamespacePrefix", p0]; }
        internal static string CreateBookmarkScopeFailed { get { return InternalSR.Instance["CreateBookmarkScopeFailed"]; } }
        internal static string CSharpExpressionsMustBeCompiled { get { return InternalSR.Instance["CSharpExpressionsMustBeCompiled"]; } }
        internal static string DebugInfoCannotEvaluateExpression(object p0) { return InternalSR.Instance["DebugInfoCannotEvaluateExpression", p0]; }
        internal static string DebugInfoExceptionCaught(object p0, object p1) { return InternalSR.Instance["DebugInfoExceptionCaught", p0, p1]; }
        internal static string DebugInfoNotSkipArgumentResolution { get { return InternalSR.Instance["DebugInfoNotSkipArgumentResolution"]; } }
        internal static string DebugInfoTryGetValueFailed { get { return InternalSR.Instance["DebugInfoTryGetValueFailed"]; } }
        internal static string DebugInstrumentationFailed(object p0) { return InternalSR.Instance["DebugInstrumentationFailed", p0]; }
        internal static string DebugSymbolChecksumValueInvalid { get { return InternalSR.Instance["DebugSymbolChecksumValueInvalid"]; } }
        internal static string DefaultAbortReason { get { return InternalSR.Instance["DefaultAbortReason"]; } }
        internal static string DefaultCancelationRequiresCancelHasBeenRequested { get { return InternalSR.Instance["DefaultCancelationRequiresCancelHasBeenRequested"]; } }
        internal static string DefaultInvalidWorkflowExceptionMessage { get { return InternalSR.Instance["DefaultInvalidWorkflowExceptionMessage"]; } }
        internal static string DefaultWorkflowApplicationExceptionMessage { get { return InternalSR.Instance["DefaultWorkflowApplicationExceptionMessage"]; } }
        internal static string DelegateArgumentAlreadyInUseOnActivity(object p0, object p1, object p2) { return InternalSR.Instance["DelegateArgumentAlreadyInUseOnActivity", p0, p1, p2]; }
        internal static string DelegateArgumentChangeBlockDU { get { return InternalSR.Instance["DelegateArgumentChangeBlockDU"]; } }
        internal static string DelegateArgumentDoesNotExist(object p0) { return InternalSR.Instance["DelegateArgumentDoesNotExist", p0]; }
        internal static string DelegateArgumentMustBeReferenced(object p0) { return InternalSR.Instance["DelegateArgumentMustBeReferenced", p0]; }
        internal static string DelegateArgumentMustBeSet { get { return InternalSR.Instance["DelegateArgumentMustBeSet"]; } }
        internal static string DelegateArgumentNotVisible(object p0) { return InternalSR.Instance["DelegateArgumentNotVisible", p0]; }
        internal static string DelegateArgumentTypeInvalid(object p0, object p1, object p2) { return InternalSR.Instance["DelegateArgumentTypeInvalid", p0, p1, p2]; }
        internal static string DelegateHandlersCannotBeScheduledDirectly(object p0, object p1) { return InternalSR.Instance["DelegateHandlersCannotBeScheduledDirectly", p0, p1]; }
        internal static string DelegateInArgumentTypeMismatch(object p0, object p1, object p2) { return InternalSR.Instance["DelegateInArgumentTypeMismatch", p0, p1, p2]; }
        internal static string DelegateOutArgumentTypeMismatch(object p0, object p1, object p2) { return InternalSR.Instance["DelegateOutArgumentTypeMismatch", p0, p1, p2]; }
        internal static string DelegateParameterCannotBeModifiedAfterOpen(object p0) { return InternalSR.Instance["DelegateParameterCannotBeModifiedAfterOpen", p0]; }
        internal static string DelegateParameterDirectionalityMismatch(object p0, object p1, object p2) { return InternalSR.Instance["DelegateParameterDirectionalityMismatch", p0, p1, p2]; }
        internal static string DictionaryIsReadOnly { get { return InternalSR.Instance["DictionaryIsReadOnly"]; } }
        internal static string DirectLambdaParameterReference { get { return InternalSR.Instance["DirectLambdaParameterReference"]; } }
        internal static string DoNotCompleteTryCommandWithPendingReclaim { get { return InternalSR.Instance["DoNotCompleteTryCommandWithPendingReclaim"]; } }
        internal static string DoNotSupportArrayIndexerOnNonArrayType(object p0) { return InternalSR.Instance["DoNotSupportArrayIndexerOnNonArrayType", p0]; }
        internal static string DoNotSupportArrayIndexerReferenceWithDifferentArrayTypeAndResultType(object p0, object p1) { return InternalSR.Instance["DoNotSupportArrayIndexerReferenceWithDifferentArrayTypeAndResultType", p0, p1]; }
        internal static string DoNotSupportArrayIndexerValueWithIncompatibleArrayTypeAndResultType(object p0, object p1) { return InternalSR.Instance["DoNotSupportArrayIndexerValueWithIncompatibleArrayTypeAndResultType", p0, p1]; }
        internal static string DoNotSupportArrayIndexerWithDifferentArrayTypeAndResultType(object p0, object p1) { return InternalSR.Instance["DoNotSupportArrayIndexerWithDifferentArrayTypeAndResultType", p0, p1]; }
        internal static string DoNotSupportArrayIndexerWithNonIntIndex(object p0) { return InternalSR.Instance["DoNotSupportArrayIndexerWithNonIntIndex", p0]; }
        internal static string DoWhileRequiresCondition(object p0) { return InternalSR.Instance["DoWhileRequiresCondition", p0]; }
        internal static string DUActivityTypeMismatch(object p0, object p1) { return InternalSR.Instance["DUActivityTypeMismatch", p0, p1]; }
        internal static string DUActivityTypeMismatchRuntime { get { return InternalSR.Instance["DUActivityTypeMismatchRuntime"]; } }
        internal static string DUDisallowIfCannotFindingMatchingCondition { get { return InternalSR.Instance["DUDisallowIfCannotFindingMatchingCondition"]; } }
        internal static string DuplicateAnnotationName(object p0) { return InternalSR.Instance["DuplicateAnnotationName", p0]; }
        internal static string DuplicateCatchClause(object p0) { return InternalSR.Instance["DuplicateCatchClause", p0]; }
        internal static string DuplicateEvaluationOrderValues(object p0, object p1) { return InternalSR.Instance["DuplicateEvaluationOrderValues", p0, p1]; }
        internal static string DuplicateImportAttribute(object p0, object p1) { return InternalSR.Instance["DuplicateImportAttribute", p0, p1]; }
        internal static string DuplicateInstrumentation(object p0) { return InternalSR.Instance["DuplicateInstrumentation", p0]; }
        internal static string DuplicateMethodFound(object p0, object p1, object p2, object p3) { return InternalSR.Instance["DuplicateMethodFound", p0, p1, p2, p3]; }
        internal static string DuplicateOriginActivityActivity(object p0, object p1, object p2) { return InternalSR.Instance["DuplicateOriginActivityActivity", p0, p1, p2]; }
        internal static string DuplicateOriginActivityVariable(object p0, object p1, object p2) { return InternalSR.Instance["DuplicateOriginActivityVariable", p0, p1, p2]; }
        internal static string DuplicateOriginVariableVariable(object p0, object p1, object p2) { return InternalSR.Instance["DuplicateOriginVariableVariable", p0, p1, p2]; }
        internal static string DurationIsNegative(object p0) { return InternalSR.Instance["DurationIsNegative", p0]; }
        internal static string DUTriggerOrConditionChangedDuringTransitioning { get { return InternalSR.Instance["DUTriggerOrConditionChangedDuringTransitioning"]; } }
        internal static string DynamicActivityDuplicatePropertyDetected(object p0) { return InternalSR.Instance["DynamicActivityDuplicatePropertyDetected", p0]; }
        internal static string DynamicActivityMultipleExpressionLanguages(object p0) { return InternalSR.Instance["DynamicActivityMultipleExpressionLanguages", p0]; }
        internal static string EmptyGuidOnDeserializedInstance { get { return InternalSR.Instance["EmptyGuidOnDeserializedInstance"]; } }
        internal static string EmptyIdReturnedFromHost(object p0) { return InternalSR.Instance["EmptyIdReturnedFromHost", p0]; }
        internal static string EnlistedTransactionPropertiesRequireIsolationBlocks { get { return InternalSR.Instance["EnlistedTransactionPropertiesRequireIsolationBlocks"]; } }
        internal static string EnumeratorNotStarted { get { return InternalSR.Instance["EnumeratorNotStarted"]; } }
        internal static string EnvironmentDisposed { get { return InternalSR.Instance["EnvironmentDisposed"]; } }
        internal static string ErrorExtractingValuesForLambdaRewrite(object p0, object p1, object p2) { return InternalSR.Instance["ErrorExtractingValuesForLambdaRewrite", p0, p1, p2]; }
        internal static string ErrorsEncounteredWhileProcessingTree { get { return InternalSR.Instance["ErrorsEncounteredWhileProcessingTree"]; } }
        internal static string EtwAPIMaxStringCountExceeded(object p0) { return InternalSR.Instance["EtwAPIMaxStringCountExceeded", p0]; }
        internal static string EtwMaxNumberArgumentsExceeded(object p0) { return InternalSR.Instance["EtwMaxNumberArgumentsExceeded", p0]; }
        internal static string EtwRegistrationFailed(object p0) { return InternalSR.Instance["EtwRegistrationFailed", p0]; }
        internal static string ExclusiveHandleRegisterBookmarkScopeFailed { get { return InternalSR.Instance["ExclusiveHandleRegisterBookmarkScopeFailed"]; } }
        internal static string ExclusiveHandleReinitializeFailed { get { return InternalSR.Instance["ExclusiveHandleReinitializeFailed"]; } }
        internal static string ExecuteMustBeNested { get { return InternalSR.Instance["ExecuteMustBeNested"]; } }
        internal static string ExecutionPropertyAlreadyDefined(object p0) { return InternalSR.Instance["ExecutionPropertyAlreadyDefined", p0]; }
        internal static string ExpressionRequiredForConversion { get { return InternalSR.Instance["ExpressionRequiredForConversion"]; } }
        internal static string ExtensionsCannotBeModified { get { return InternalSR.Instance["ExtensionsCannotBeModified"]; } }
        internal static string ExtensionsCannotBeSetByIndex { get { return InternalSR.Instance["ExtensionsCannotBeSetByIndex"]; } }
        internal static string ExternalLocationsGetOnly { get { return InternalSR.Instance["ExternalLocationsGetOnly"]; } }
        internal static string ExtraOverloadGroupPropertiesConfigured(object p0, object p1, object p2) { return InternalSR.Instance["ExtraOverloadGroupPropertiesConfigured", p0, p1, p2]; }
        internal static string FailFastMessage(object p0) { return InternalSR.Instance["FailFastMessage", p0]; }
        internal static string FaultContextNotFound(object p0) { return InternalSR.Instance["FaultContextNotFound", p0]; }
        internal static string FinalStateCannotHaveProperty(object p0, object p1) { return InternalSR.Instance["FinalStateCannotHaveProperty", p0, p1]; }
        internal static string FinalStateCannotHaveTransition(object p0) { return InternalSR.Instance["FinalStateCannotHaveTransition", p0]; }
        internal static string FlowchartContainsReferences { get { return InternalSR.Instance["FlowchartContainsReferences"]; } }
        internal static string FlowchartContainsUnconnectedNodes(object p0) { return InternalSR.Instance["FlowchartContainsUnconnectedNodes", p0]; }
        internal static string FlowchartMissingStartNode(object p0) { return InternalSR.Instance["FlowchartMissingStartNode", p0]; }
        internal static string FlowDecisionRequiresCondition(object p0) { return InternalSR.Instance["FlowDecisionRequiresCondition", p0]; }
        internal static string FlowNodeCannotBeShared(object p0, object p1) { return InternalSR.Instance["FlowNodeCannotBeShared", p0, p1]; }
        internal static string FlowNodeLockedForRuntime(object p0) { return InternalSR.Instance["FlowNodeLockedForRuntime", p0]; }
        internal static string FlowSwitchRequiresExpression(object p0) { return InternalSR.Instance["FlowSwitchRequiresExpression", p0]; }
        internal static string ForEachRequiresNonNullValues(object p0) { return InternalSR.Instance["ForEachRequiresNonNullValues", p0]; }
        internal static string GeneratedAndProvidedMapConflict { get { return InternalSR.Instance["GeneratedAndProvidedMapConflict"]; } }
        internal static string GeneratedAndProvidedMapConflictRuntime { get { return InternalSR.Instance["GeneratedAndProvidedMapConflictRuntime"]; } }
        internal static string GenericInstanceCommand(object p0) { return InternalSR.Instance["GenericInstanceCommand", p0]; }
        internal static string GenericInstanceCommandNull { get { return InternalSR.Instance["GenericInstanceCommandNull"]; } }
        internal static string GetLocationOnPublicAccessReference(object p0) { return InternalSR.Instance["GetLocationOnPublicAccessReference", p0]; }
        internal static string GetParameterTypeMismatch(object p0, object p1) { return InternalSR.Instance["GetParameterTypeMismatch", p0, p1]; }
        internal static string GetRunnableRequiresOwner { get { return InternalSR.Instance["GetRunnableRequiresOwner"]; } }
        internal static string GuidCannotBeEmpty { get { return InternalSR.Instance["GuidCannotBeEmpty"]; } }
        internal static string HandleFreed { get { return InternalSR.Instance["HandleFreed"]; } }
        internal static string HandleFreedBeforeInitialized { get { return InternalSR.Instance["HandleFreedBeforeInitialized"]; } }
        internal static string HandleInitializationContextDisposed { get { return InternalSR.Instance["HandleInitializationContextDisposed"]; } }
        internal static string HandleNotInitialized { get { return InternalSR.Instance["HandleNotInitialized"]; } }
        internal static string HasExecutingChildrenNoPersist { get { return InternalSR.Instance["HasExecutingChildrenNoPersist"]; } }
        internal static string HostIdDoesNotMatchInstance(object p0, object p1) { return InternalSR.Instance["HostIdDoesNotMatchInstance", p0, p1]; }
        internal static string IdentityControlCharacter { get { return InternalSR.Instance["IdentityControlCharacter"]; } }
        internal static string IdentityNameSemicolon { get { return InternalSR.Instance["IdentityNameSemicolon"]; } }
        internal static string IdentityWhitespace { get { return InternalSR.Instance["IdentityWhitespace"]; } }
        internal static string IdNotFoundInWorkflow(object p0) { return InternalSR.Instance["IdNotFoundInWorkflow", p0]; }
        internal static string ImplementationVersionMismatch(object p0, object p1, object p2) { return InternalSR.Instance["ImplementationVersionMismatch", p0, p1, p2]; }
        internal static string IncompatibleArgumentType(object p0, object p1) { return InternalSR.Instance["IncompatibleArgumentType", p0, p1]; }
        internal static string IncompatibleTypeForMultidimensionalArrayItemReference(object p0, object p1) { return InternalSR.Instance["IncompatibleTypeForMultidimensionalArrayItemReference", p0, p1]; }
        internal static string IncorrectIndexForArgument(object p0, object p1, object p2) { return InternalSR.Instance["IncorrectIndexForArgument", p0, p1, p2]; }
        internal static string IncorrectValueType(object p0, object p1) { return InternalSR.Instance["IncorrectValueType", p0, p1]; }
        internal static string IndexOutOfBounds(object p0, object p1) { return InternalSR.Instance["IndexOutOfBounds", p0, p1]; }
        internal static string IndicesAreNeeded(object p0, object p1) { return InternalSR.Instance["IndicesAreNeeded", p0, p1]; }
        internal static string InitializationIncomplete { get { return InternalSR.Instance["InitializationIncomplete"]; } }
        internal static string InitialMetadataCannotBeDeleted(object p0) { return InternalSR.Instance["InitialMetadataCannotBeDeleted", p0]; }
        internal static string InitialStateCannotBeFinalState(object p0) { return InternalSR.Instance["InitialStateCannotBeFinalState", p0]; }
        internal static string InitialStateNotInStatesCollection(object p0) { return InternalSR.Instance["InitialStateNotInStatesCollection", p0]; }
        internal static string InlinedLocationReferenceOnlyAccessibleByOwner(object p0, object p1) { return InternalSR.Instance["InlinedLocationReferenceOnlyAccessibleByOwner", p0, p1]; }
        internal static string InputParametersCountMismatch(object p0, object p1) { return InternalSR.Instance["InputParametersCountMismatch", p0, p1]; }
        internal static string InputParametersMissing(object p0) { return InternalSR.Instance["InputParametersMissing", p0]; }
        internal static string InputParametersTypeMismatch(object p0, object p1) { return InternalSR.Instance["InputParametersTypeMismatch", p0, p1]; }
        internal static string InstanceCollisionDefault { get { return InternalSR.Instance["InstanceCollisionDefault"]; } }
        internal static string InstanceCollisionSpecific(object p0) { return InternalSR.Instance["InstanceCollisionSpecific", p0]; }
        internal static string InstanceCompleteDefault { get { return InternalSR.Instance["InstanceCompleteDefault"]; } }
        internal static string InstanceCompleteSpecific(object p0) { return InternalSR.Instance["InstanceCompleteSpecific", p0]; }
        internal static string InstanceHandleConflictDefault { get { return InternalSR.Instance["InstanceHandleConflictDefault"]; } }
        internal static string InstanceHandleConflictSpecific(object p0) { return InternalSR.Instance["InstanceHandleConflictSpecific", p0]; }
        internal static string InstanceKeyRequiresValidGuid { get { return InternalSR.Instance["InstanceKeyRequiresValidGuid"]; } }
        internal static string InstanceLockLostDefault { get { return InternalSR.Instance["InstanceLockLostDefault"]; } }
        internal static string InstanceLockLostSpecific(object p0) { return InternalSR.Instance["InstanceLockLostSpecific", p0]; }
        internal static string InstanceMethodCallRequiresTargetObject { get { return InternalSR.Instance["InstanceMethodCallRequiresTargetObject"]; } }
        internal static string InstanceMustBePaused { get { return InternalSR.Instance["InstanceMustBePaused"]; } }
        internal static string InstanceMustNotBePaused { get { return InternalSR.Instance["InstanceMustNotBePaused"]; } }
        internal static string InstanceNotReadyDefault { get { return InternalSR.Instance["InstanceNotReadyDefault"]; } }
        internal static string InstanceNotReadySpecific(object p0) { return InternalSR.Instance["InstanceNotReadySpecific", p0]; }
        internal static string InstanceOperationRequiresInstance { get { return InternalSR.Instance["InstanceOperationRequiresInstance"]; } }
        internal static string InstanceOperationRequiresLock { get { return InternalSR.Instance["InstanceOperationRequiresLock"]; } }
        internal static string InstanceOperationRequiresNotCompleted { get { return InternalSR.Instance["InstanceOperationRequiresNotCompleted"]; } }
        internal static string InstanceOperationRequiresNotUninitialized { get { return InternalSR.Instance["InstanceOperationRequiresNotUninitialized"]; } }
        internal static string InstanceOperationRequiresOwner { get { return InternalSR.Instance["InstanceOperationRequiresOwner"]; } }
        internal static string InstanceOwnerDefault { get { return InternalSR.Instance["InstanceOwnerDefault"]; } }
        internal static string InstanceOwnerSpecific(object p0) { return InternalSR.Instance["InstanceOwnerSpecific", p0]; }
        internal static string InstanceRequired { get { return InternalSR.Instance["InstanceRequired"]; } }
        internal static string InstanceStoreBoundSameVersionTwice { get { return InternalSR.Instance["InstanceStoreBoundSameVersionTwice"]; } }
        internal static string InstanceStoreDoesntMatchWorkflowApplication { get { return InternalSR.Instance["InstanceStoreDoesntMatchWorkflowApplication"]; } }
        internal static string InstanceStoreFailed { get { return InternalSR.Instance["InstanceStoreFailed"]; } }
        internal static string InstanceStoreHasDefaultOwner { get { return InternalSR.Instance["InstanceStoreHasDefaultOwner"]; } }
        internal static string InstanceStoreRequiredToPersist { get { return InternalSR.Instance["InstanceStoreRequiredToPersist"]; } }
        internal static string InsufficientArraySize(object p0) { return InternalSR.Instance["InsufficientArraySize", p0]; }
        internal static string InternalConstraintException(object p0, object p1, object p2, object p3) { return InternalSR.Instance["InternalConstraintException", p0, p1, p2, p3]; }
        internal static string InvalidActivityIdFormat { get { return InternalSR.Instance["InvalidActivityIdFormat"]; } }
        internal static string InvalidActivityToBlockUpdate(object p0) { return InternalSR.Instance["InvalidActivityToBlockUpdate", p0]; }
        internal static string InvalidActivityToBlockUpdateServices(object p0) { return InternalSR.Instance["InvalidActivityToBlockUpdateServices", p0]; }
        internal static string InvalidArgumentExpression(object p0, object p1) { return InternalSR.Instance["InvalidArgumentExpression", p0, p1]; }
        internal static string InvalidAsyncBeginMethodSignature(object p0, object p1) { return InternalSR.Instance["InvalidAsyncBeginMethodSignature", p0, p1]; }
        internal static string InvalidAsyncCancelMethodSignature(object p0, object p1) { return InternalSR.Instance["InvalidAsyncCancelMethodSignature", p0, p1]; }
        internal static string InvalidAsyncEndMethodSignature(object p0, object p1) { return InternalSR.Instance["InvalidAsyncEndMethodSignature", p0, p1]; }
        internal static string InvalidAsyncResult { get { return InternalSR.Instance["InvalidAsyncResult"]; } }
        internal static string InvalidAsyncResultImplementation(object p0) { return InternalSR.Instance["InvalidAsyncResultImplementation", p0]; }
        internal static string InvalidAsyncResultImplementationGeneric { get { return InternalSR.Instance["InvalidAsyncResultImplementationGeneric"]; } }
        internal static string InvalidCallbackState(object p0) { return InternalSR.Instance["InvalidCallbackState", p0]; }
        internal static string InvalidCompensateActivityUsage(object p0) { return InternalSR.Instance["InvalidCompensateActivityUsage", p0]; }
        internal static string InvalidCompensationToken(object p0) { return InternalSR.Instance["InvalidCompensationToken", p0]; }
        internal static string InvalidConfirmActivityUsage(object p0) { return InternalSR.Instance["InvalidConfirmActivityUsage", p0]; }
        internal static string InvalidDirectionForArgument(object p0, object p1, object p2, object p3) { return InternalSR.Instance["InvalidDirectionForArgument", p0, p1, p2, p3]; }
        internal static string InvalidDynamicActivityProperty(object p0) { return InternalSR.Instance["InvalidDynamicActivityProperty", p0]; }
        internal static string InvalidEvaluationOrderValue { get { return InternalSR.Instance["InvalidEvaluationOrderValue"]; } }
        internal static string InvalidExecutionCallback(object p0, object p1) { return InternalSR.Instance["InvalidExecutionCallback", p0, p1]; }
        internal static string InvalidExpressionForLocation(object p0) { return InternalSR.Instance["InvalidExpressionForLocation", p0]; }
        internal static string InvalidExpressionProperty(object p0) { return InternalSR.Instance["InvalidExpressionProperty", p0]; }
        internal static string InvalidFileName(object p0) { return InternalSR.Instance["InvalidFileName", p0]; }
        internal static string InvalidGenericTypeInfo(object p0) { return InternalSR.Instance["InvalidGenericTypeInfo", p0]; }
        internal static string InvalidIdleAction { get { return InternalSR.Instance["InvalidIdleAction"]; } }
        internal static string InvalidImplementationAsWorkflowRoot { get { return InternalSR.Instance["InvalidImplementationAsWorkflowRoot"]; } }
        internal static string InvalidImplementationAsWorkflowRootForRuntimeState { get { return InternalSR.Instance["InvalidImplementationAsWorkflowRootForRuntimeState"]; } }
        internal static string InvalidImplementationAsWorkflowRootForRuntimeStateBecauseArgumentsChanged { get { return InternalSR.Instance["InvalidImplementationAsWorkflowRootForRuntimeStateBecauseArgumentsChanged"]; } }
        internal static string InvalidImplementationMap(object p0, object p1) { return InternalSR.Instance["InvalidImplementationMap", p0, p1]; }
        internal static string InvalidImplementationMapAssociation(object p0) { return InternalSR.Instance["InvalidImplementationMapAssociation", p0]; }
        internal static string InvalidImplementationMapAssociationServices(object p0) { return InternalSR.Instance["InvalidImplementationMapAssociationServices", p0]; }
        internal static string InvalidImplementationMapRuntime { get { return InternalSR.Instance["InvalidImplementationMapRuntime"]; } }
        internal static string InvalidInstanceState { get { return InternalSR.Instance["InvalidInstanceState"]; } }
        internal static string InvalidKeyArgument { get { return InternalSR.Instance["InvalidKeyArgument"]; } }
        internal static string InvalidLocationExpression { get { return InternalSR.Instance["InvalidLocationExpression"]; } }
        internal static string InvalidLockToken { get { return InternalSR.Instance["InvalidLockToken"]; } }
        internal static string InvalidLValueExpression { get { return InternalSR.Instance["InvalidLValueExpression"]; } }
        internal static string InvalidMergeMap(object p0, object p1, object p2) { return InternalSR.Instance["InvalidMergeMap", p0, p1, p2]; }
        internal static string InvalidMergeMapArgumentCount(object p0, object p1) { return InternalSR.Instance["InvalidMergeMapArgumentCount", p0, p1]; }
        internal static string InvalidMergeMapArgumentsChanged { get { return InternalSR.Instance["InvalidMergeMapArgumentsChanged"]; } }
        internal static string InvalidMergeMapEnvironmentCount(object p0, object p1, object p2, object p3, object p4, object p5) { return InternalSR.Instance["InvalidMergeMapEnvironmentCount", p0, p1, p2, p3, p4, p5]; }
        internal static string InvalidMergeMapForImplementation(object p0, object p1) { return InternalSR.Instance["InvalidMergeMapForImplementation", p0, p1]; }
        internal static string InvalidMergeMapMemberCount(object p0, object p1) { return InternalSR.Instance["InvalidMergeMapMemberCount", p0, p1]; }
        internal static string InvalidNullAsyncResult { get { return InternalSR.Instance["InvalidNullAsyncResult"]; } }
        internal static string InvalidOriginalWorkflowDefinitionForImplementationMapCreation { get { return InternalSR.Instance["InvalidOriginalWorkflowDefinitionForImplementationMapCreation"]; } }
        internal static string InvalidParameterInfo(object p0, object p1) { return InternalSR.Instance["InvalidParameterInfo", p0, p1]; }
        internal static string InvalidPrepareForRuntimeValidationSettings { get { return InternalSR.Instance["InvalidPrepareForRuntimeValidationSettings"]; } }
        internal static string InvalidProperty(object p0) { return InternalSR.Instance["InvalidProperty", p0]; }
        internal static string InvalidPropertyType(object p0, object p1) { return InternalSR.Instance["InvalidPropertyType", p0, p1]; }
        internal static string InvalidRootMergeMap(object p0, object p1) { return InternalSR.Instance["InvalidRootMergeMap", p0, p1]; }
        internal static string InvalidRuntimeState { get { return InternalSR.Instance["InvalidRuntimeState"]; } }
        internal static string InvalidSemaphoreExit { get { return InternalSR.Instance["InvalidSemaphoreExit"]; } }
        internal static string InvalidSourceLocationColumn(object p0, object p1) { return InternalSR.Instance["InvalidSourceLocationColumn", p0, p1]; }
        internal static string InvalidSourceLocationLineNumber(object p0, object p1) { return InternalSR.Instance["InvalidSourceLocationLineNumber", p0, p1]; }
        internal static string InvalidStateForAsyncCallback { get { return InternalSR.Instance["InvalidStateForAsyncCallback"]; } }
        internal static string InvalidStateInAsyncResult { get { return InternalSR.Instance["InvalidStateInAsyncResult"]; } }
        internal static string InvalidTypeConverterUsage { get { return InternalSR.Instance["InvalidTypeConverterUsage"]; } }
        internal static string InvalidTypeForArgument(object p0, object p1, object p2, object p3) { return InternalSR.Instance["InvalidTypeForArgument", p0, p1, p2, p3]; }
        internal static string InvalidUnhandledExceptionAction { get { return InternalSR.Instance["InvalidUnhandledExceptionAction"]; } }
        internal static string InvalidUpdatedWorkflowDefinitionForImplementationMapCreation { get { return InternalSR.Instance["InvalidUpdatedWorkflowDefinitionForImplementationMapCreation"]; } }
        internal static string InvalidUpdateMap(object p0) { return InternalSR.Instance["InvalidUpdateMap", p0]; }
        internal static string InvalidVisualBasicSettingsValue { get { return InternalSR.Instance["InvalidVisualBasicSettingsValue"]; } }
        internal static string InvalidXamlMember(object p0) { return InternalSR.Instance["InvalidXamlMember", p0]; }
        internal static string IsolationLevelValidation { get { return InternalSR.Instance["IsolationLevelValidation"]; } }
        internal static string ITextExpressionParameterMustBeActivity { get { return InternalSR.Instance["ITextExpressionParameterMustBeActivity"]; } }
        internal static string KeyAlreadyAssociated { get { return InternalSR.Instance["KeyAlreadyAssociated"]; } }
        internal static string KeyAlreadyCompleted { get { return InternalSR.Instance["KeyAlreadyCompleted"]; } }
        internal static string KeyAlreadyUnassociated { get { return InternalSR.Instance["KeyAlreadyUnassociated"]; } }
        internal static string KeyCollectionUpdatesNotAllowed { get { return InternalSR.Instance["KeyCollectionUpdatesNotAllowed"]; } }
        internal static string KeyCollisionDefault { get { return InternalSR.Instance["KeyCollisionDefault"]; } }
        internal static string KeyCollisionSpecific(object p0, object p1, object p2) { return InternalSR.Instance["KeyCollisionSpecific", p0, p1, p2]; }
        internal static string KeyCollisionSpecificKeyOnly(object p0) { return InternalSR.Instance["KeyCollisionSpecificKeyOnly", p0]; }
        internal static string KeyCompleteDefault { get { return InternalSR.Instance["KeyCompleteDefault"]; } }
        internal static string KeyCompleteSpecific(object p0) { return InternalSR.Instance["KeyCompleteSpecific", p0]; }
        internal static string KeyNotAssociated { get { return InternalSR.Instance["KeyNotAssociated"]; } }
        internal static string KeyNotCompleted { get { return InternalSR.Instance["KeyNotCompleted"]; } }
        internal static string KeyNotFoundInDictionary { get { return InternalSR.Instance["KeyNotFoundInDictionary"]; } }
        internal static string KeyNotReadyDefault { get { return InternalSR.Instance["KeyNotReadyDefault"]; } }
        internal static string KeyNotReadySpecific(object p0) { return InternalSR.Instance["KeyNotReadySpecific", p0]; }
        internal static string LambdaExpressionReturnTypeInvalid { get { return InternalSR.Instance["LambdaExpressionReturnTypeInvalid"]; } }
        internal static string LambdaExpressionTypeRequired { get { return InternalSR.Instance["LambdaExpressionTypeRequired"]; } }
        internal static string LambdaNotXamlSerializable { get { return InternalSR.Instance["LambdaNotXamlSerializable"]; } }
        internal static string LineNumberTooLarge(object p0) { return InternalSR.Instance["LineNumberTooLarge", p0]; }
        internal static string LiteralsMustBeValueTypesOrImmutableTypes(object p0, object p1) { return InternalSR.Instance["LiteralsMustBeValueTypesOrImmutableTypes", p0, p1]; }
        internal static string LoadedWriteOnlyValue { get { return InternalSR.Instance["LoadedWriteOnlyValue"]; } }
        internal static string LoadingWorkflowApplicationRequiresInstanceStore { get { return InternalSR.Instance["LoadingWorkflowApplicationRequiresInstanceStore"]; } }
        internal static string LoadOpAssociateKeysCannotContainLookupKey { get { return InternalSR.Instance["LoadOpAssociateKeysCannotContainLookupKey"]; } }
        internal static string LoadOpFreeKeyRequiresAcceptUninitialized { get { return InternalSR.Instance["LoadOpFreeKeyRequiresAcceptUninitialized"]; } }
        internal static string LoadOpKeyMustBeValid { get { return InternalSR.Instance["LoadOpKeyMustBeValid"]; } }
        internal static string LocationExpressionCouldNotBeResolved(object p0) { return InternalSR.Instance["LocationExpressionCouldNotBeResolved", p0]; }
        internal static string LocationTypeMismatch(object p0, object p1, object p2) { return InternalSR.Instance["LocationTypeMismatch", p0, p1, p2]; }
        internal static string LockTimeoutExceptionMessage(object p0) { return InternalSR.Instance["LockTimeoutExceptionMessage", p0]; }
        internal static string MapEntryNotFound(object p0) { return InternalSR.Instance["MapEntryNotFound", p0]; }
        internal static string MarkCanceledOnlyCallableIfCancelRequested { get { return InternalSR.Instance["MarkCanceledOnlyCallableIfCancelRequested"]; } }
        internal static string MayBindLockCommandShouldValidateOwner { get { return InternalSR.Instance["MayBindLockCommandShouldValidateOwner"]; } }
        internal static string MemberCannotBeNull(object p0, object p1, object p2) { return InternalSR.Instance["MemberCannotBeNull", p0, p1, p2]; }
        internal static string MemberIsReadOnly(object p0, object p1) { return InternalSR.Instance["MemberIsReadOnly", p0, p1]; }
        internal static string MemberNotFound(object p0, object p1) { return InternalSR.Instance["MemberNotFound", p0, p1]; }
        internal static string MemberNotSupportedByActivityXamlServices(object p0) { return InternalSR.Instance["MemberNotSupportedByActivityXamlServices", p0]; }
        internal static string MetadataCannotContainNullKey { get { return InternalSR.Instance["MetadataCannotContainNullKey"]; } }
        internal static string MetadataCannotContainNullValue(object p0) { return InternalSR.Instance["MetadataCannotContainNullValue", p0]; }
        internal static string MethodInfoRequired(object p0) { return InternalSR.Instance["MethodInfoRequired", p0]; }
        internal static string MethodNameRequired(object p0) { return InternalSR.Instance["MethodNameRequired", p0]; }
        internal static string MissingArgument(object p0, object p1) { return InternalSR.Instance["MissingArgument", p0, p1]; }
        internal static string MissingNameProperty(object p0) { return InternalSR.Instance["MissingNameProperty", p0]; }
        internal static string MissingSetAccessorForIndexer(object p0, object p1) { return InternalSR.Instance["MissingSetAccessorForIndexer", p0, p1]; }
        internal static string MovingActivitiesInStateBlockDU { get { return InternalSR.Instance["MovingActivitiesInStateBlockDU"]; } }
        internal static string MultiDimensionalArraysNotSupported { get { return InternalSR.Instance["MultiDimensionalArraysNotSupported"]; } }
        internal static string MultipleFlowNodesSharingSameChildBlockDU { get { return InternalSR.Instance["MultipleFlowNodesSharingSameChildBlockDU"]; } }
        internal static string MultipleOverloadGroupsConfigured(object p0) { return InternalSR.Instance["MultipleOverloadGroupsConfigured", p0]; }
        internal static string MustCallPrepareBeforeFinalize { get { return InternalSR.Instance["MustCallPrepareBeforeFinalize"]; } }
        internal static string MustCancelOldTimer { get { return InternalSR.Instance["MustCancelOldTimer"]; } }
        internal static string MustMatchReferenceExpressionReturnType { get { return InternalSR.Instance["MustMatchReferenceExpressionReturnType"]; } }
        internal static string MustSetTransactionOnFirstCall { get { return InternalSR.Instance["MustSetTransactionOnFirstCall"]; } }
        internal static string NameCollisionOnCollect(object p0, object p1) { return InternalSR.Instance["NameCollisionOnCollect", p0, p1]; }
        internal static string NameCollisionOnMap(object p0, object p1) { return InternalSR.Instance["NameCollisionOnMap", p0, p1]; }
        internal static string NativeActivityUpdateInstanceThrewException(object p0) { return InternalSR.Instance["NativeActivityUpdateInstanceThrewException", p0]; }
        internal static string NAUCDisposed { get { return InternalSR.Instance["NAUCDisposed"]; } }
        internal static string NewArrayBoundsRequiresIntegralArguments { get { return InternalSR.Instance["NewArrayBoundsRequiresIntegralArguments"]; } }
        internal static string NewArrayRequiresArrayTypeAsResultType { get { return InternalSR.Instance["NewArrayRequiresArrayTypeAsResultType"]; } }
        internal static string NoCAInSecondaryRoot { get { return InternalSR.Instance["NoCAInSecondaryRoot"]; } }
        internal static string NoChangesMapQueryNotSupported { get { return InternalSR.Instance["NoChangesMapQueryNotSupported"]; } }
        internal static string NoDynamicArgumentsInActivityDefinitionChange { get { return InternalSR.Instance["NoDynamicArgumentsInActivityDefinitionChange"]; } }
        internal static string NoDynamicArgumentsInActivityDefinitionChangeRuntime { get { return InternalSR.Instance["NoDynamicArgumentsInActivityDefinitionChangeRuntime"]; } }
        internal static string NoNamespace(object p0) { return InternalSR.Instance["NoNamespace", p0]; }
        internal static string NoOutputLocationWasFound(object p0) { return InternalSR.Instance["NoOutputLocationWasFound", p0]; }
        internal static string NoOverloadGroupsAreConfigured { get { return InternalSR.Instance["NoOverloadGroupsAreConfigured"]; } }
        internal static string NoPersistScopeCannotContainPersist(object p0, object p1) { return InternalSR.Instance["NoPersistScopeCannotContainPersist", p0, p1]; }
        internal static string NoRunnableInstances { get { return InternalSR.Instance["NoRunnableInstances"]; } }
        internal static string NoRuntimeTransactionExists { get { return InternalSR.Instance["NoRuntimeTransactionExists"]; } }
        internal static string NullAssignedToValueType(object p0) { return InternalSR.Instance["NullAssignedToValueType", p0]; }
        internal static string NullKeyAlreadyPresent { get { return InternalSR.Instance["NullKeyAlreadyPresent"]; } }
        internal static string NullReferencedMemberAccess(object p0, object p1) { return InternalSR.Instance["NullReferencedMemberAccess", p0, p1]; }
        internal static string OnCancelRequestedThrew { get { return InternalSR.Instance["OnCancelRequestedThrew"]; } }
        internal static string OneOfTwoPropertiesMustBeSet(object p0, object p1, object p2, object p3) { return InternalSR.Instance["OneOfTwoPropertiesMustBeSet", p0, p1, p2, p3]; }
        internal static string OnFreeInstanceHandleThrew { get { return InternalSR.Instance["OnFreeInstanceHandleThrew"]; } }
        internal static string OnlyBookmarkOwnerCanRemove { get { return InternalSR.Instance["OnlyBookmarkOwnerCanRemove"]; } }
        internal static string OnlyOneOperationPerActivity { get { return InternalSR.Instance["OnlyOneOperationPerActivity"]; } }
        internal static string OnlyOneRequireTransactionContextAllowed { get { return InternalSR.Instance["OnlyOneRequireTransactionContextAllowed"]; } }
        internal static string OnlySingleCastDelegatesAllowed { get { return InternalSR.Instance["OnlySingleCastDelegatesAllowed"]; } }
        internal static string OperationAlreadyCompleted { get { return InternalSR.Instance["OperationAlreadyCompleted"]; } }
        internal static string OptionalExtensionTypeMatchedMultiple(object p0) { return InternalSR.Instance["OptionalExtensionTypeMatchedMultiple", p0]; }
        internal static string OriginalActivityReusedInModifiedDefinition(object p0) { return InternalSR.Instance["OriginalActivityReusedInModifiedDefinition", p0]; }
        internal static string OriginalVariableReusedInModifiedDefinition(object p0) { return InternalSR.Instance["OriginalVariableReusedInModifiedDefinition", p0]; }
        internal static string OriginCannotBeRuntimeIntrinsic(object p0) { return InternalSR.Instance["OriginCannotBeRuntimeIntrinsic", p0]; }
        internal static string OutArgumentCannotHaveInputValue(object p0) { return InternalSR.Instance["OutArgumentCannotHaveInputValue", p0]; }
        internal static string OutOfIdSpaceIds { get { return InternalSR.Instance["OutOfIdSpaceIds"]; } }
        internal static string OutOfInstanceIds { get { return InternalSR.Instance["OutOfInstanceIds"]; } }
        internal static string OutOfInternalBookmarks { get { return InternalSR.Instance["OutOfInternalBookmarks"]; } }
        internal static string OutOfRangeSourceLocationEndColumn(object p0) { return InternalSR.Instance["OutOfRangeSourceLocationEndColumn", p0]; }
        internal static string OutOfRangeSourceLocationEndLine(object p0) { return InternalSR.Instance["OutOfRangeSourceLocationEndLine", p0]; }
        internal static string OutsideInstanceExecutionScope(object p0) { return InternalSR.Instance["OutsideInstanceExecutionScope", p0]; }
        internal static string OutsideTransactionalCommand(object p0) { return InternalSR.Instance["OutsideTransactionalCommand", p0]; }
        internal static string OverloadGroupHasSubsets(object p0, object p1) { return InternalSR.Instance["OverloadGroupHasSubsets", p0, p1]; }
        internal static string OverloadGroupsAreEquivalent(object p0) { return InternalSR.Instance["OverloadGroupsAreEquivalent", p0]; }
        internal static string OverloadingMethodMustBeStatic { get { return InternalSR.Instance["OverloadingMethodMustBeStatic"]; } }
        internal static string OverloadOnlyCallableFromWorkflowThread { get { return InternalSR.Instance["OverloadOnlyCallableFromWorkflowThread"]; } }
        internal static string OwnerBelongsToWrongStore { get { return InternalSR.Instance["OwnerBelongsToWrongStore"]; } }
        internal static string OwnerRequired { get { return InternalSR.Instance["OwnerRequired"]; } }
        internal static string ParallelForEachRequiresNonNullValues(object p0) { return InternalSR.Instance["ParallelForEachRequiresNonNullValues", p0]; }
        internal static string PauseWhenPersistableInvalidIfPersistable { get { return InternalSR.Instance["PauseWhenPersistableInvalidIfPersistable"]; } }
        internal static string PermissionArgumentWrongType(object p0) { return InternalSR.Instance["PermissionArgumentWrongType", p0]; }
        internal static string PersistenceInitializerThrew { get { return InternalSR.Instance["PersistenceInitializerThrew"]; } }
        internal static string PersistencePipelineAbortThrew(object p0) { return InternalSR.Instance["PersistencePipelineAbortThrew", p0]; }
        internal static string PickBranchRequiresTrigger(object p0) { return InternalSR.Instance["PickBranchRequiresTrigger", p0]; }
        internal static string PickBranchTriggerActionSwapped { get { return InternalSR.Instance["PickBranchTriggerActionSwapped"]; } }
        internal static string PrepareForSerializationRequiresPersistability { get { return InternalSR.Instance["PrepareForSerializationRequiresPersistability"]; } }
        internal static string PrivateMembersHaveChanged { get { return InternalSR.Instance["PrivateMembersHaveChanged"]; } }
        internal static string PropertyCannotBeModified(object p0) { return InternalSR.Instance["PropertyCannotBeModified", p0]; }
        internal static string PropertyMemberNotSupportedByActivityXamlServices(object p0) { return InternalSR.Instance["PropertyMemberNotSupportedByActivityXamlServices", p0]; }
        internal static string PropertyReadOnlyInWorkflowDataContext(object p0) { return InternalSR.Instance["PropertyReadOnlyInWorkflowDataContext", p0]; }
        internal static string PropertyReferenceNotFound(object p0) { return InternalSR.Instance["PropertyReferenceNotFound", p0]; }
        internal static string ProvidedStateInitializedForExecution { get { return InternalSR.Instance["ProvidedStateInitializedForExecution"]; } }
        internal static string ProviderDoesNotSupportCommand(object p0) { return InternalSR.Instance["ProviderDoesNotSupportCommand", p0]; }
        internal static string PublicChildrenChangeBlockDU { get { return InternalSR.Instance["PublicChildrenChangeBlockDU"]; } }
        internal static string PublicEnvironmentAccessToNonGenericActivity { get { return InternalSR.Instance["PublicEnvironmentAccessToNonGenericActivity"]; } }
        internal static string PublicMethodWithMatchingParameterDoesNotExist(object p0, object p1, object p2, object p3) { return InternalSR.Instance["PublicMethodWithMatchingParameterDoesNotExist", p0, p1, p2, p3]; }
        internal static string PublicReferencesOnActivityRequiringArgumentResolution(object p0) { return InternalSR.Instance["PublicReferencesOnActivityRequiringArgumentResolution", p0]; }
        internal static string QueryActivityIsInImplementation(object p0) { return InternalSR.Instance["QueryActivityIsInImplementation", p0]; }
        internal static string QueryActivityIsNotInDefinition { get { return InternalSR.Instance["QueryActivityIsNotInDefinition"]; } }
        internal static string QueryActivityIsPublic(object p0) { return InternalSR.Instance["QueryActivityIsPublic", p0]; }
        internal static string QueryVariableIsInImplementation(object p0) { return InternalSR.Instance["QueryVariableIsInImplementation", p0]; }
        internal static string QueryVariableIsNotInDefinition { get { return InternalSR.Instance["QueryVariableIsNotInDefinition"]; } }
        internal static string QueryVariableIsNotPublic { get { return InternalSR.Instance["QueryVariableIsNotPublic"]; } }
        internal static string QueryVariableIsPublic(object p0) { return InternalSR.Instance["QueryVariableIsPublic", p0]; }
        internal static string ReadAccessToWriteOnlyPublicReference(object p0) { return InternalSR.Instance["ReadAccessToWriteOnlyPublicReference", p0]; }
        internal static string ReadNotSupported { get { return InternalSR.Instance["ReadNotSupported"]; } }
        internal static string ReadonlyNameScopeCannotBeUpdated { get { return InternalSR.Instance["ReadonlyNameScopeCannotBeUpdated"]; } }
        internal static string ReadonlyPropertyCannotBeSet(object p0, object p1) { return InternalSR.Instance["ReadonlyPropertyCannotBeSet", p0, p1]; }
        internal static string ReferencedChildInIsNewlyAdded { get { return InternalSR.Instance["ReferencedChildInIsNewlyAdded"]; } }
        internal static string RegisteredBookmarkScopeRequired { get { return InternalSR.Instance["RegisteredBookmarkScopeRequired"]; } }
        internal static string RemovingTransitionsBlockDU { get { return InternalSR.Instance["RemovingTransitionsBlockDU"]; } }
        internal static string RequiredArgumentValueNotSupplied(object p0) { return InternalSR.Instance["RequiredArgumentValueNotSupplied", p0]; }
        internal static string RequiredExtensionTypeNotFound(object p0) { return InternalSR.Instance["RequiredExtensionTypeNotFound", p0]; }
        internal static string RequiredVariableCoundNotBeExtracted(object p0, object p1) { return InternalSR.Instance["RequiredVariableCoundNotBeExtracted", p0, p1]; }
        internal static string RequireExtensionOnlyAcceptsReferenceTypes(object p0) { return InternalSR.Instance["RequireExtensionOnlyAcceptsReferenceTypes", p0]; }
        internal static string ResultArgumentHasRequiredTypeAndDirection(object p0, object p1, object p2) { return InternalSR.Instance["ResultArgumentHasRequiredTypeAndDirection", p0, p1, p2]; }
        internal static string ResultArgumentMustBeBoundToResultProperty { get { return InternalSR.Instance["ResultArgumentMustBeBoundToResultProperty"]; } }
        internal static string ResultArgumentMustBeSpecificType(object p0) { return InternalSR.Instance["ResultArgumentMustBeSpecificType", p0]; }
        internal static string ResultCannotBeSetOnArgumentExpressions { get { return InternalSR.Instance["ResultCannotBeSetOnArgumentExpressions"]; } }
        internal static string RethrowMustBeAPublicChild(object p0) { return InternalSR.Instance["RethrowMustBeAPublicChild", p0]; }
        internal static string RethrowNotInATryCatch(object p0) { return InternalSR.Instance["RethrowNotInATryCatch", p0]; }
        internal static string ReturnTypeIncompatible(object p0, object p1, object p2, object p3, object p4) { return InternalSR.Instance["ReturnTypeIncompatible", p0, p1, p2, p3, p4]; }
        internal static string RootActivityAlreadyAssociatedWithInstance(object p0) { return InternalSR.Instance["RootActivityAlreadyAssociatedWithInstance", p0]; }
        internal static string RootActivityCannotBeReferenced(object p0, object p1) { return InternalSR.Instance["RootActivityCannotBeReferenced", p0, p1]; }
        internal static string RootArgumentViolationsFound { get { return InternalSR.Instance["RootArgumentViolationsFound"]; } }
        internal static string RootArgumentViolationsFoundNoInputs { get { return InternalSR.Instance["RootArgumentViolationsFoundNoInputs"]; } }
        internal static string RuntimeArgumentBindingInvalid(object p0, object p1) { return InternalSR.Instance["RuntimeArgumentBindingInvalid", p0, p1]; }
        internal static string RuntimeArgumentChangeBlockDU(object p0) { return InternalSR.Instance["RuntimeArgumentChangeBlockDU", p0]; }
        internal static string RuntimeArgumentNotCreated { get { return InternalSR.Instance["RuntimeArgumentNotCreated"]; } }
        internal static string RuntimeArgumentNotOpen(object p0) { return InternalSR.Instance["RuntimeArgumentNotOpen", p0]; }
        internal static string RuntimeDelegateArgumentDirectionIncorrect { get { return InternalSR.Instance["RuntimeDelegateArgumentDirectionIncorrect"]; } }
        internal static string RuntimeDelegateArgumentTypeIncorrect { get { return InternalSR.Instance["RuntimeDelegateArgumentTypeIncorrect"]; } }
        internal static string RuntimeOperationInProgress { get { return InternalSR.Instance["RuntimeOperationInProgress"]; } }
        internal static string RuntimeRunning { get { return InternalSR.Instance["RuntimeRunning"]; } }
        internal static string RuntimeTransactionAlreadyExists { get { return InternalSR.Instance["RuntimeTransactionAlreadyExists"]; } }
        internal static string RuntimeTransactionHandleNotRegisteredAsExecutionProperty(object p0) { return InternalSR.Instance["RuntimeTransactionHandleNotRegisteredAsExecutionProperty", p0]; }
        internal static string RuntimeTransactionIsSuppressed { get { return InternalSR.Instance["RuntimeTransactionIsSuppressed"]; } }
        internal static string SameUserStateUsedForMultipleInvokes { get { return InternalSR.Instance["SameUserStateUsedForMultipleInvokes"]; } }
        internal static string SavingActivityToXamlNotSupported { get { return InternalSR.Instance["SavingActivityToXamlNotSupported"]; } }
        internal static string SavingFuncToXamlNotSupported { get { return InternalSR.Instance["SavingFuncToXamlNotSupported"]; } }
        internal static string SchemaContextFromBeforeInitializeComponentXBTExtensionCannotBeGeneric(object p0) { return InternalSR.Instance["SchemaContextFromBeforeInitializeComponentXBTExtensionCannotBeGeneric", p0]; }
        internal static string SchemaContextFromBeforeInitializeComponentXBTExtensionNotFound(object p0) { return InternalSR.Instance["SchemaContextFromBeforeInitializeComponentXBTExtensionNotFound", p0]; }
        internal static string SeekNotSupported { get { return InternalSR.Instance["SeekNotSupported"]; } }
        internal static string SendNotSupported { get { return InternalSR.Instance["SendNotSupported"]; } }
        internal static string SequenceDuplicateReferences { get { return InternalSR.Instance["SequenceDuplicateReferences"]; } }
        internal static string SetupOrCleanupWorkflowThreadThrew { get { return InternalSR.Instance["SetupOrCleanupWorkflowThreadThrew"]; } }
        internal static string SFxTaskNotStarted { get { return InternalSR.Instance["SFxTaskNotStarted"]; } }
        internal static string ShipAssertExceptionMessage(object p0) { return InternalSR.Instance["ShipAssertExceptionMessage", p0]; }
        internal static string SimpleStateMustHaveOneTransition(object p0) { return InternalSR.Instance["SimpleStateMustHaveOneTransition", p0]; }
        internal static string SpecialMethodNotFound(object p0, object p1) { return InternalSR.Instance["SpecialMethodNotFound", p0, p1]; }
        internal static string StateCannotBeAddedTwice(object p0) { return InternalSR.Instance["StateCannotBeAddedTwice", p0]; }
        internal static string StateCannotBeSerialized(object p0) { return InternalSR.Instance["StateCannotBeSerialized", p0]; }
        internal static string StateMachineMustHaveInitialState(object p0) { return InternalSR.Instance["StateMachineMustHaveInitialState", p0]; }
        internal static string StateNotBelongToAnyParent(object p0, object p1) { return InternalSR.Instance["StateNotBelongToAnyParent", p0, p1]; }
        internal static string StoreReportedConflictingLockTokens { get { return InternalSR.Instance["StoreReportedConflictingLockTokens"]; } }
        internal static string SubexpressionResultWasNotVisible(object p0) { return InternalSR.Instance["SubexpressionResultWasNotVisible", p0]; }
        internal static string SubexpressionResultWasNull(object p0) { return InternalSR.Instance["SubexpressionResultWasNull", p0]; }
        internal static string SwitchCaseKeyTypesMustMatchExpressionType(object p0, object p1, object p2) { return InternalSR.Instance["SwitchCaseKeyTypesMustMatchExpressionType", p0, p1, p2]; }
        internal static string SwitchCaseNullWithValueType(object p0) { return InternalSR.Instance["SwitchCaseNullWithValueType", p0]; }
        internal static string SwitchCaseTypeMismatch(object p0, object p1) { return InternalSR.Instance["SwitchCaseTypeMismatch", p0, p1]; }
        internal static string SymbolNamesMustBeUnique(object p0) { return InternalSR.Instance["SymbolNamesMustBeUnique", p0]; }
        internal static string SymbolResolverAlreadyExists { get { return InternalSR.Instance["SymbolResolverAlreadyExists"]; } }
        internal static string SymbolResolverDoesNotHaveSymbol(object p0, object p1) { return InternalSR.Instance["SymbolResolverDoesNotHaveSymbol", p0, p1]; }
        internal static string SymbolResolverMustBeSingleton { get { return InternalSR.Instance["SymbolResolverMustBeSingleton"]; } }
        internal static string TargetTypeAndTargetObjectAreMutuallyExclusive(object p0, object p1) { return InternalSR.Instance["TargetTypeAndTargetObjectAreMutuallyExclusive", p0, p1]; }
        internal static string TargetTypeCannotBeEnum(object p0, object p1) { return InternalSR.Instance["TargetTypeCannotBeEnum", p0, p1]; }
        internal static string TargetTypeIsValueType(object p0, object p1) { return InternalSR.Instance["TargetTypeIsValueType", p0, p1]; }
        internal static string TaskTimedOutError(object p0) { return InternalSR.Instance["TaskTimedOutError", p0]; }
        internal static string TextExpressionCompilerActivityNameRequired { get { return InternalSR.Instance["TextExpressionCompilerActivityNameRequired"]; } }
        internal static string TextExpressionCompilerActivityNamespaceRequired { get { return InternalSR.Instance["TextExpressionCompilerActivityNamespaceRequired"]; } }
        internal static string TextExpressionCompilerActivityRequired { get { return InternalSR.Instance["TextExpressionCompilerActivityRequired"]; } }
        internal static string TextExpressionCompilerAddGeneratedFileRequired { get { return InternalSR.Instance["TextExpressionCompilerAddGeneratedFileRequired"]; } }
        internal static string TextExpressionCompilerLanguageRequired { get { return InternalSR.Instance["TextExpressionCompilerLanguageRequired"]; } }
        internal static string TextExpressionCompilerNoCodebase(object p0) { return InternalSR.Instance["TextExpressionCompilerNoCodebase", p0]; }
        internal static string TextExpressionCompilerOutputPathRequired { get { return InternalSR.Instance["TextExpressionCompilerOutputPathRequired"]; } }
        internal static string TextExpressionCompilerUnableToLoadAssembly(object p0) { return InternalSR.Instance["TextExpressionCompilerUnableToLoadAssembly", p0]; }
        internal static string TextExpressionMetadataRequiresCompilation(object p0) { return InternalSR.Instance["TextExpressionMetadataRequiresCompilation", p0]; }
        internal static string ThreadNeutralSemaphoreAborted { get { return InternalSR.Instance["ThreadNeutralSemaphoreAborted"]; } }
        internal static string TimedOutWaitingForLockResolution { get { return InternalSR.Instance["TimedOutWaitingForLockResolution"]; } }
        internal static string TimeoutInputQueueDequeue(object p0) { return InternalSR.Instance["TimeoutInputQueueDequeue", p0]; }
        internal static string TimeoutMustBeNonNegative(object p0, object p1) { return InternalSR.Instance["TimeoutMustBeNonNegative", p0, p1]; }
        internal static string TimeoutMustBePositive(object p0, object p1) { return InternalSR.Instance["TimeoutMustBePositive", p0, p1]; }
        internal static string TimeoutOnOperation(object p0) { return InternalSR.Instance["TimeoutOnOperation", p0]; }
        internal static string TimerExtensionAlreadyAttached { get { return InternalSR.Instance["TimerExtensionAlreadyAttached"]; } }
        internal static string TimerExtensionRequiresWorkflowInstance { get { return InternalSR.Instance["TimerExtensionRequiresWorkflowInstance"]; } }
        internal static string TooManyViolationsForExceptionMessage { get { return InternalSR.Instance["TooManyViolationsForExceptionMessage"]; } }
        internal static string TrackingRelatedWorkflowAbort { get { return InternalSR.Instance["TrackingRelatedWorkflowAbort"]; } }
        internal static string TransactionHandleAlreadyHasTransaction { get { return InternalSR.Instance["TransactionHandleAlreadyHasTransaction"]; } }
        internal static string TransactionInDoubtNonHost { get { return InternalSR.Instance["TransactionInDoubtNonHost"]; } }
        internal static string TransactionRolledBackNonHost { get { return InternalSR.Instance["TransactionRolledBackNonHost"]; } }
        internal static string TransitionCannotBeAddedTwice(object p0, object p1, object p2) { return InternalSR.Instance["TransitionCannotBeAddedTwice", p0, p1, p2]; }
        internal static string TransitionTargetCannotBeNull(object p0, object p1) { return InternalSR.Instance["TransitionTargetCannotBeNull", p0, p1]; }
        internal static string TriggerOrConditionChangedDuringTransitioning { get { return InternalSR.Instance["TriggerOrConditionChangedDuringTransitioning"]; } }
        internal static string TriggerOrConditionIsReferenced { get { return InternalSR.Instance["TriggerOrConditionIsReferenced"]; } }
        internal static string TryCatchInvalidStateForUpdate(object p0) { return InternalSR.Instance["TryCatchInvalidStateForUpdate", p0]; }
        internal static string TryCommandCannotExecuteSubCommandsAndReduce { get { return InternalSR.Instance["TryCommandCannotExecuteSubCommandsAndReduce"]; } }
        internal static string TryLoadRequiresOwner { get { return InternalSR.Instance["TryLoadRequiresOwner"]; } }
        internal static string TypeConverterHelperCacheAddFailed(object p0) { return InternalSR.Instance["TypeConverterHelperCacheAddFailed", p0]; }
        internal static string TypeMismatchForAssign(object p0, object p1, object p2) { return InternalSR.Instance["TypeMismatchForAssign", p0, p1, p2]; }
        internal static string TypeMustbeValueType(object p0) { return InternalSR.Instance["TypeMustbeValueType", p0]; }
        internal static string TypeNotAssignableTo(object p0, object p1) { return InternalSR.Instance["TypeNotAssignableTo", p0, p1]; }
        internal static string UnableToLocateCompiledLocationContext(object p0) { return InternalSR.Instance["UnableToLocateCompiledLocationContext", p0]; }
        internal static string UnconditionalTransitionShouldNotShareNullTriggersWithOthers(object p0, object p1) { return InternalSR.Instance["UnconditionalTransitionShouldNotShareNullTriggersWithOthers", p0, p1]; }
        internal static string UnconditionalTransitionShouldNotShareTriggersWithOthers(object p0, object p1, object p2) { return InternalSR.Instance["UnconditionalTransitionShouldNotShareTriggersWithOthers", p0, p1, p2]; }
        internal static string UnexpectedArgumentCount(object p0, object p1, object p2) { return InternalSR.Instance["UnexpectedArgumentCount", p0, p1, p2]; }
        internal static string UnexpectedExpressionNodeType(object p0, object p1) { return InternalSR.Instance["UnexpectedExpressionNodeType", p0, p1]; }
        internal static string UninitializedCannotHaveData { get { return InternalSR.Instance["UninitializedCannotHaveData"]; } }
        internal static string UnInitializedRuntimeTransactionHandle { get { return InternalSR.Instance["UnInitializedRuntimeTransactionHandle"]; } }
        internal static string UnknownExpressionCompilationError(object p0) { return InternalSR.Instance["UnknownExpressionCompilationError", p0]; }
        internal static string UnknownLanguage(object p0) { return InternalSR.Instance["UnknownLanguage", p0]; }
        internal static string UnmatchedNoPersistExit { get { return InternalSR.Instance["UnmatchedNoPersistExit"]; } }
        internal static string UnopenedActivitiesCannotBeExecuted(object p0) { return InternalSR.Instance["UnopenedActivitiesCannotBeExecuted", p0]; }
        internal static string UnsupportedExpressionType(object p0) { return InternalSR.Instance["UnsupportedExpressionType", p0]; }
        internal static string UnsupportedLocationReferenceValue { get { return InternalSR.Instance["UnsupportedLocationReferenceValue"]; } }
        internal static string UnsupportedMemberExpressionWithType(object p0) { return InternalSR.Instance["UnsupportedMemberExpressionWithType", p0]; }
        internal static string UnsupportedReferenceExpressionType(object p0) { return InternalSR.Instance["UnsupportedReferenceExpressionType", p0]; }
        internal static string UnusedInputArguments(object p0) { return InternalSR.Instance["UnusedInputArguments", p0]; }
        internal static string UpdateMapBuilderRequiredProperty(object p0) { return InternalSR.Instance["UpdateMapBuilderRequiredProperty", p0]; }
        internal static string UpdateSymbolsMustMatch { get { return InternalSR.Instance["UpdateSymbolsMustMatch"]; } }
        internal static string ValidateUnlockInstance { get { return InternalSR.Instance["ValidateUnlockInstance"]; } }
        internal static string ValidationContextCannotBeNull(object p0, object p1) { return InternalSR.Instance["ValidationContextCannotBeNull", p0, p1]; }
        internal static string ValidationErrorPrefixForHiddenActivity(object p0) { return InternalSR.Instance["ValidationErrorPrefixForHiddenActivity", p0]; }
        internal static string ValidationErrorPrefixForPublicActivityWithHiddenParent(object p0, object p1) { return InternalSR.Instance["ValidationErrorPrefixForPublicActivityWithHiddenParent", p0, p1]; }
        internal static string ValueCollectionUpdatesNotAllowed { get { return InternalSR.Instance["ValueCollectionUpdatesNotAllowed"]; } }
        internal static string ValueMustBeAssignableToType { get { return InternalSR.Instance["ValueMustBeAssignableToType"]; } }
        internal static string ValueMustBeNonNegative { get { return InternalSR.Instance["ValueMustBeNonNegative"]; } }
        internal static string VariableAlreadyInUseOnActivity(object p0, object p1, object p2) { return InternalSR.Instance["VariableAlreadyInUseOnActivity", p0, p1, p2]; }
        internal static string VariableCannotBePopulatedInLocationEnvironment(object p0) { return InternalSR.Instance["VariableCannotBePopulatedInLocationEnvironment", p0]; }
        internal static string VariableDoesNotExist(object p0) { return InternalSR.Instance["VariableDoesNotExist", p0]; }
        internal static string VariableExpressionTypeMismatch(object p0, object p1, object p2) { return InternalSR.Instance["VariableExpressionTypeMismatch", p0, p1, p2]; }
        internal static string VariableIsReadOnly(object p0) { return InternalSR.Instance["VariableIsReadOnly", p0]; }
        internal static string VariableMustBeSet { get { return InternalSR.Instance["VariableMustBeSet"]; } }
        internal static string VariableNameNotAnIdentifier(object p0) { return InternalSR.Instance["VariableNameNotAnIdentifier", p0]; }
        internal static string VariableNotOpen(object p0, object p1) { return InternalSR.Instance["VariableNotOpen", p0, p1]; }
        internal static string VariableNotVisible(object p0) { return InternalSR.Instance["VariableNotVisible", p0]; }
        internal static string VariableOnlyAccessibleAtScopeOfDeclaration(object p0, object p1) { return InternalSR.Instance["VariableOnlyAccessibleAtScopeOfDeclaration", p0, p1]; }
        internal static string VariableOrArgumentAdditionToReferencedEnvironmentNoDUSupported { get { return InternalSR.Instance["VariableOrArgumentAdditionToReferencedEnvironmentNoDUSupported"]; } }
        internal static string VariableOrArgumentDoesNotExist(object p0) { return InternalSR.Instance["VariableOrArgumentDoesNotExist", p0]; }
        internal static string VariableShouldBeOpen(object p0) { return InternalSR.Instance["VariableShouldBeOpen", p0]; }
        internal static string VariableTypeInvalid(object p0, object p1, object p2) { return InternalSR.Instance["VariableTypeInvalid", p0, p1, p2]; }
        internal static string VariableTypeNotMatchLocationType(object p0, object p1) { return InternalSR.Instance["VariableTypeNotMatchLocationType", p0, p1]; }
        internal static string VBExpressionTamperedSinceLastCompiled(object p0) { return InternalSR.Instance["VBExpressionTamperedSinceLastCompiled", p0]; }
        internal static string WaitAlreadyInProgress { get { return InternalSR.Instance["WaitAlreadyInProgress"]; } }
        internal static string WaitForEventsTimedOut(object p0) { return InternalSR.Instance["WaitForEventsTimedOut", p0]; }
        internal static string WDCDisposed { get { return InternalSR.Instance["WDCDisposed"]; } }
        internal static string WhileRequiresCondition(object p0) { return InternalSR.Instance["WhileRequiresCondition", p0]; }
        internal static string WorkflowAbortedReason(object p0, object p1) { return InternalSR.Instance["WorkflowAbortedReason", p0, p1]; }
        internal static string WorkflowApplicationAborted(object p0) { return InternalSR.Instance["WorkflowApplicationAborted", p0]; }
        internal static string WorkflowApplicationAlreadyHasId { get { return InternalSR.Instance["WorkflowApplicationAlreadyHasId"]; } }
        internal static string WorkflowApplicationCompleted(object p0) { return InternalSR.Instance["WorkflowApplicationCompleted", p0]; }
        internal static string WorkflowApplicationInstanceAbandoned { get { return InternalSR.Instance["WorkflowApplicationInstanceAbandoned"]; } }
        internal static string WorkflowApplicationInstanceLoaded { get { return InternalSR.Instance["WorkflowApplicationInstanceLoaded"]; } }
        internal static string WorkflowApplicationTerminated(object p0) { return InternalSR.Instance["WorkflowApplicationTerminated", p0]; }
        internal static string WorkflowApplicationUnloaded(object p0) { return InternalSR.Instance["WorkflowApplicationUnloaded", p0]; }
        internal static string WorkflowIdentityNullHostId(object p0) { return InternalSR.Instance["WorkflowIdentityNullHostId", p0]; }
        internal static string WorkflowIdentityNullStateId(object p0) { return InternalSR.Instance["WorkflowIdentityNullStateId", p0]; }
        internal static string WorkflowIdentityStateIdHostIdMismatch(object p0, object p1) { return InternalSR.Instance["WorkflowIdentityStateIdHostIdMismatch", p0, p1]; }
        internal static string WorkflowInstanceAborted(object p0) { return InternalSR.Instance["WorkflowInstanceAborted", p0]; }
        internal static string WorkflowInstanceIsReadOnly(object p0) { return InternalSR.Instance["WorkflowInstanceIsReadOnly", p0]; }
        internal static string WorkflowInstanceNotFoundInStore(object p0) { return InternalSR.Instance["WorkflowInstanceNotFoundInStore", p0]; }
        internal static string WorkflowInstanceUnlocked(object p0) { return InternalSR.Instance["WorkflowInstanceUnlocked", p0]; }
        internal static string WorkflowTerminatedExceptionDefaultMessage { get { return InternalSR.Instance["WorkflowTerminatedExceptionDefaultMessage"]; } }
        internal static string WorkItemAbortedInstance { get { return InternalSR.Instance["WorkItemAbortedInstance"]; } }
        internal static string WriteAccessToReadOnlyPublicReference(object p0) { return InternalSR.Instance["WriteAccessToReadOnlyPublicReference", p0]; }
        internal static string WriteonlyPropertyCannotBeRead(object p0, object p1) { return InternalSR.Instance["WriteonlyPropertyCannotBeRead", p0, p1]; }
        internal static string WrongArgumentType(object p0, object p1) { return InternalSR.Instance["WrongArgumentType", p0, p1]; }
        internal static string WrongCacheMetadataForCodeActivity { get { return InternalSR.Instance["WrongCacheMetadataForCodeActivity"]; } }
        internal static string WrongCacheMetadataForNativeActivity { get { return InternalSR.Instance["WrongCacheMetadataForNativeActivity"]; } }
        internal static string WrongEnvironmentCount(object p0, object p1, object p2, object p3, object p4, object p5, object p6, object p7, object p8) { return InternalSR.Instance["WrongEnvironmentCount", p0, p1, p2, p3, p4, p5, p6, p7, p8]; }
        internal static string WrongMemberCount(object p0, object p1, object p2) { return InternalSR.Instance["WrongMemberCount", p0, p1, p2]; }
        internal static string WrongNumberOfArgumentsForActivityDelegate { get { return InternalSR.Instance["WrongNumberOfArgumentsForActivityDelegate"]; } }
        internal static string WrongOnCreateDynamicUpdateMapForNativeActivity { get { return InternalSR.Instance["WrongOnCreateDynamicUpdateMapForNativeActivity"]; } }
        internal static string WrongOriginalEnvironmentCount(object p0, object p1, object p2, object p3, object p4, object p5, object p6) { return InternalSR.Instance["WrongOriginalEnvironmentCount", p0, p1, p2, p3, p4, p5, p6]; }
        internal static string XamlBuildTaskResourceNotFound(object p0) { return InternalSR.Instance["XamlBuildTaskResourceNotFound", p0]; }
        internal static string XamlElementExpected { get { return InternalSR.Instance["XamlElementExpected"]; } }
        internal static string XamlElementExpectedAt(object p0, object p1) { return InternalSR.Instance["XamlElementExpectedAt", p0, p1]; }
    }
}
